using System.Collections.Generic;
using System.Linq;
using System.Text;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using HandlebarsDotNet;
using System.Text.RegularExpressions;
using System.Text.Json;
using static RcpDocParser;
using System.Dynamic;

public static class Program
{
    const string supportedObjectRemove = "and/or";
    const string supportedTextLabel = "JSON Supported Objects:";

    private static readonly Regex _rcpParamNAmeRegex = new Regex("RCP_PARAM_[a-zA-Z0-9_]+");
    public static void Main(string[] args)
    {

        Handlebars.RegisterHelper("toConstantCase", (writer, context, parameters) =>
        {
            writer.Write((parameters[0]?.ToString() ?? "").ToConstantCase());
        });

        readPdf();

    }

    private static void readPdf()
    {
        var allParamstext=File.ReadAllLines("./allRcpPArams.txt");
        var parsedParams=allParamstext.ToDictionary(p=>p,p=>null as RcpParam);


        

        using (PdfDocument document = PdfDocument.Open(@"D:\personal\red doc\RED RCP2 DOCUMENTATION V1_5_4\910-0276 Rev-A RED ENG, KOMODO RCP2 Parameters.pdf"))
        {

            var rcpLineBuilder = new StringBuilder();
            var rcpLines = new List<string>();
            var rcpParamErrors = new List<string>();
            var currentParamName="";

            var pageNumber = 0;

            using var parsererrWriter = File.CreateText("rcp-err.txt");
            using var parserLogWriter = File.CreateText("rcp-parser-log.txt");

            foreach (Page page in document.GetPages())
            {

                pageNumber++;

                if (pageNumber >= 6)
                {
                    var inPAramBlock = false;
                    var enumerator = page.GetWords().GetEnumerator();

                    while (enumerator.MoveNext())
                    {
                        var wordStr = enumerator.Current.Text;

                        var nextWordStr = "";

                        if (_rcpParamNAmeRegex.IsMatch(wordStr))
                        {
                            if (enumerator.MoveNext())
                            {
                                nextWordStr = enumerator.Current.Text;

                                if (nextWordStr == "Type:")
                                {
                                    
                                    
                                    // new param block.Process previous line
                                    var rcpLine = rcpLineBuilder.ToString();                                    

                                    if (!string.IsNullOrWhiteSpace(rcpLine))
                                    {
                                        rcpLines.Add(rcpLine);
                                        try
                                        {
                                            parsedParams[currentParamName]=parseLine(rcpLine, parserLogWriter, parsererrWriter);
                                        }
                                        catch (System.Exception e)
                                        {
                                            parsererrWriter.WriteLine($"error parsing page {pageNumber}: {e.Message}");
                                            parserLogWriter.WriteLine($"error parsing page {pageNumber}: {e.Message}");
                                            rcpParamErrors.Add(rcpLine);
                                        }
                                    }
                                    // start new param block.

                                    inPAramBlock = true;
                                    rcpLineBuilder.Clear();
                                    currentParamName=wordStr;                                    
                                    parsererrWriter.WriteLine(currentParamName);
                                    parserLogWriter.WriteLine(currentParamName);
                                }
                            }

                            rcpLineBuilder.Append(wordStr);
                            rcpLineBuilder.Append(" ");

                            rcpLineBuilder.Append(nextWordStr);
                            rcpLineBuilder.Append(" ");

                        }
                        else
                        {
                            if (inPAramBlock)
                            {
                                rcpLineBuilder.Append(wordStr);
                                rcpLineBuilder.Append(" ");
                            }

                        }

                    }
                    // new param block.Process previous line
                    var lastrcpLine = rcpLineBuilder.ToString();
                    rcpLines.Add(lastrcpLine);

                    if (!string.IsNullOrWhiteSpace(lastrcpLine))
                    {
                        rcpLineBuilder.Clear();
                        try
                        {
                             parsedParams[currentParamName]=parseLine(lastrcpLine, parserLogWriter, parsererrWriter);
                        }
                        catch (System.Exception e)
                        {
                            parsererrWriter.WriteLine($"error parsing page {pageNumber}: {e.Message}");
                            parserLogWriter.WriteLine($"error parsing page {pageNumber}: {e.Message}");
                            rcpParamErrors.Add(lastrcpLine);
                        }
                    }

                }

            }
            rcpLines.Add($"ERRORS- {string.Join(',', rcpParamErrors)}");
            var unprocessedParams=parsedParams.Where(kv=>kv.Value == null).Select(kv=>kv.Key);
            var processedParams=parsedParams.Where(kv=>kv.Value != null).Select(kv=>kv.Value);
            rcpLines.Add($"UNPROCESSED- {string.Join(',', unprocessedParams)}");

            var jsonString = JsonSerializer.Serialize(processedParams.ToArray());

            File.WriteAllText("./rcp-params-original.json", jsonString);

            //   File.WriteAllText("./rcp-params.cpp", template(new { RcpParams = parsedParams.ToArray() }));
            File.AppendAllLines("./rcp-raw.txt", rcpLines);
        }
    }

    private static RcpParam parseLine(string rcpLine, TextWriter output, TextWriter errorOutput)
    {
        var str = new AntlrInputStream(rcpLine);
        var lexer = new RcpDocLexer(str);

        var tokens = new CommonTokenStream(lexer);
        var parser = new RcpDocParser(tokens, output, errorOutput);

        var rcpParamBlock = parser.rcpParamBlock();
        return GetRcpParam(rcpParamBlock);
    }


    private static RcpParam GetRcpParam(RcpDocParser.RcpParamBlockContext rcpParamBlock)
    {
        var rcpParam = new RcpParam();

        rcpParam.ParamName = rcpParamBlock.rcpParamName().GetText();
        rcpParam.ParamType = rcpParamBlock.rcpParamTypeBlock().typeValue().IDENTIFIER().GetText();
        rcpParam.ParamTypeFull = rcpParamBlock.rcpParamTypeBlock().typeValue().GetText();
        rcpParam.Desc = getDesc(rcpParamBlock);
        rcpParam.SupportedObects = getSupportedObjects(rcpParamBlock);
        if (rcpParamBlock.typesJsonBlock() != null)
        {
            rcpParam.TypesJson = getTypesJsonforKeyValuePairs(rcpParamBlock.typesJsonBlock().jsonKeyValuePair());
        }
        return rcpParam;

    }

    private static Dictionary<string, object> getTypesJsonforKeyValuePairs(JsonKeyValuePairContext[] jsonKeyValuePairs)
    {
        var obj = new Dictionary<string, object>();
        foreach (var jsonKeyValuePair in jsonKeyValuePairs)
        {
            var key = jsonKeyValuePair.JSON_STRING().GetText().Trim('"');

            if (jsonKeyValuePair.jsonValue().JSON_CONST() != null)
            {
                obj.Add(key, jsonKeyValuePair.jsonValue().JSON_CONST().GetText());
            }

            if (jsonKeyValuePair.jsonValue().JSON_NUMBER() != null)
            {
                obj.Add(key, jsonKeyValuePair.jsonValue().JSON_NUMBER().GetText());
            }


            if (jsonKeyValuePair.jsonValue().JSON_STRING() != null)
            {
                var valString = jsonKeyValuePair.jsonValue().JSON_STRING().GetText().Trim('"');
                obj.Add(key, valString);
            }

            if (jsonKeyValuePair.jsonValue().jsonObject() != null)
            {
                var valObj = getTypesJsonforKeyValuePairs(jsonKeyValuePair.jsonValue().jsonObject().jsonKeyValuePair());
                obj.Add(key, valObj);
            }

        }
        return obj;


    }

    private static IEnumerable<string> getSupportedObjects(RcpDocParser.RcpParamBlockContext rcpParamBlock)
    {
        return rcpParamBlock.supportedObjectValues()?.supportedObjectValue()?.Select(s => s.GetText()).Where(s => s != supportedObjectRemove);
    }

    private static string getDesc(RcpDocParser.RcpParamBlockContext rcpParamBlock)
    {

        return string.Join(' ', rcpParamBlock.paramDesc().children.Where(child => child.GetText() != supportedTextLabel).Select(c => c.GetText()));
    }
}
