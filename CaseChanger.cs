using System.Text;

/// <summary>
/// change sring ftom an to camelCase, PascalCase, Capital Case, snake_case, param-case, CONSTANT_CASE
/// </summary>
public static class CaseChanger
{
    private static IEnumerable<string> parseString(string input)
    {
        var ret = new List<string>();

        var sb= new StringBuilder();


        foreach (var ch in input)
        {
            if(char.IsLower(ch)){
                sb.Append(ch);
            }else{
                ret.Add(sb.ToString());
                sb.Clear();
                
                if(char.IsLetterOrDigit(ch)){
                    sb.Append(char.ToLowerInvariant(ch));
                }
            }
            
        }

         ret.Add(sb.ToString());

        return ret;
    }

    public static string ToConstantCase(this string input)
    {
        var parts=parseString(input);
        return string.Join('_', parts).ToUpperInvariant();
    }

}