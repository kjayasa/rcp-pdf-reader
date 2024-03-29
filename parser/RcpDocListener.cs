//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./parser/grammer/RcpDoc.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="RcpDocParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public interface IRcpDocListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="RcpDocParser.rcpParamBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRcpParamBlock([NotNull] RcpDocParser.RcpParamBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RcpDocParser.rcpParamBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRcpParamBlock([NotNull] RcpDocParser.RcpParamBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RcpDocParser.rcpParamName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRcpParamName([NotNull] RcpDocParser.RcpParamNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RcpDocParser.rcpParamName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRcpParamName([NotNull] RcpDocParser.RcpParamNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RcpDocParser.rcpParamTypeBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRcpParamTypeBlock([NotNull] RcpDocParser.RcpParamTypeBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RcpDocParser.rcpParamTypeBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRcpParamTypeBlock([NotNull] RcpDocParser.RcpParamTypeBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RcpDocParser.typeValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeValue([NotNull] RcpDocParser.TypeValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RcpDocParser.typeValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeValue([NotNull] RcpDocParser.TypeValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RcpDocParser.supportedObjectValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSupportedObjectValues([NotNull] RcpDocParser.SupportedObjectValuesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RcpDocParser.supportedObjectValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSupportedObjectValues([NotNull] RcpDocParser.SupportedObjectValuesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RcpDocParser.supportedObjectValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSupportedObjectValue([NotNull] RcpDocParser.SupportedObjectValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RcpDocParser.supportedObjectValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSupportedObjectValue([NotNull] RcpDocParser.SupportedObjectValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RcpDocParser.paramDesc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParamDesc([NotNull] RcpDocParser.ParamDescContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RcpDocParser.paramDesc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParamDesc([NotNull] RcpDocParser.ParamDescContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RcpDocParser.typesJsonBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypesJsonBlock([NotNull] RcpDocParser.TypesJsonBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RcpDocParser.typesJsonBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypesJsonBlock([NotNull] RcpDocParser.TypesJsonBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RcpDocParser.jsonKeyValuePair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJsonKeyValuePair([NotNull] RcpDocParser.JsonKeyValuePairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RcpDocParser.jsonKeyValuePair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJsonKeyValuePair([NotNull] RcpDocParser.JsonKeyValuePairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RcpDocParser.jsonValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJsonValue([NotNull] RcpDocParser.JsonValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RcpDocParser.jsonValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJsonValue([NotNull] RcpDocParser.JsonValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RcpDocParser.jsonObject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJsonObject([NotNull] RcpDocParser.JsonObjectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RcpDocParser.jsonObject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJsonObject([NotNull] RcpDocParser.JsonObjectContext context);
}
