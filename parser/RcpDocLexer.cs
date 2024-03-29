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

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public partial class RcpDocLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, RCP_PARAM_NAME=4, PARAM_TYPE_LABEL=5, SUPPORTED_LABEL=6, 
		AND_OR=7, TYPES_JSON_LABEL=8, SUPPORTED_VALUE=9, JSON_NUMBER=10, JSON_CONST=11, 
		JSON_STRING=12, IDENTIFIER=13, PARAM_TYPE_EXTRA=14, WS=15;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "RCP_PARAM_NAME", "PARAM_TYPE_LABEL", "SUPPORTED_LABEL", 
		"AND_OR", "TYPES_JSON_LABEL", "SUPPORTED_VALUE", "JSON_NUMBER", "JSON_CONST", 
		"JSON_STRING", "IDENTIFIER", "PARAM_TYPE_EXTRA", "WS"
	};


	public RcpDocLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public RcpDocLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "':'", "'{'", "'}'", null, "'Type:'", "'JSON Supported Objects:'", 
		"'and/or'", "'TYPES'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "RCP_PARAM_NAME", "PARAM_TYPE_LABEL", "SUPPORTED_LABEL", 
		"AND_OR", "TYPES_JSON_LABEL", "SUPPORTED_VALUE", "JSON_NUMBER", "JSON_CONST", 
		"JSON_STRING", "IDENTIFIER", "PARAM_TYPE_EXTRA", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "RcpDoc.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static RcpDocLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x11', '\xAC', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x6', '\n', '\x66', 
		'\n', '\n', '\r', '\n', '\xE', '\n', 'g', '\x3', '\v', '\x5', '\v', 'k', 
		'\n', '\v', '\x3', '\v', '\x3', '\v', '\x5', '\v', 'o', '\n', '\v', '\x3', 
		'\v', '\x6', '\v', 'r', '\n', '\v', '\r', '\v', '\xE', '\v', 's', '\x3', 
		'\v', '\x3', '\v', '\x6', '\v', 'x', '\n', '\v', '\r', '\v', '\xE', '\v', 
		'y', '\x5', '\v', '|', '\n', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x5', '\f', '\x8E', '\n', '\f', '\x3', '\r', 
		'\x3', '\r', '\a', '\r', '\x92', '\n', '\r', '\f', '\r', '\xE', '\r', 
		'\x95', '\v', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x6', '\xE', 
		'\x9A', '\n', '\xE', '\r', '\xE', '\xE', '\xE', '\x9B', '\x3', '\xF', 
		'\x3', '\xF', '\x6', '\xF', '\xA0', '\n', '\xF', '\r', '\xF', '\xE', '\xF', 
		'\xA1', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x6', '\x10', '\xA7', 
		'\n', '\x10', '\r', '\x10', '\xE', '\x10', '\xA8', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\xA1', '\x2', '\x11', '\x3', '\x3', '\x5', '\x4', '\a', 
		'\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', 
		'\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', 
		'\x1D', '\x10', '\x1F', '\x11', '\x3', '\x2', '\t', '\x4', '\x2', '\x43', 
		'H', '\x63', 'h', '\x4', '\x2', 'Z', 'Z', 'z', 'z', '\x3', '\x2', '\x32', 
		';', '\x5', '\x2', '\f', '\f', '\xF', '\xF', '$', '$', '\x6', '\x2', '\x32', 
		';', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x6', '\x2', '\v', '\f', 
		'\xF', '\xF', '\"', '\"', '*', '*', '\x5', '\x2', '\v', '\f', '\xF', '\xF', 
		'\"', '\"', '\x2', '\xB8', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '!', '\x3', '\x2', '\x2', '\x2', '\x5', '#', '\x3', '\x2', '\x2', 
		'\x2', '\a', '%', '\x3', '\x2', '\x2', '\x2', '\t', '\'', '\x3', '\x2', 
		'\x2', '\x2', '\v', '\x34', '\x3', '\x2', '\x2', '\x2', '\r', ':', '\x3', 
		'\x2', '\x2', '\x2', '\xF', 'R', '\x3', '\x2', '\x2', '\x2', '\x11', 'Y', 
		'\x3', '\x2', '\x2', '\x2', '\x13', '_', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'j', '\x3', '\x2', '\x2', '\x2', '\x17', '\x8D', '\x3', '\x2', '\x2', 
		'\x2', '\x19', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x99', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', '\x9D', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		'\xA6', '\x3', '\x2', '\x2', '\x2', '!', '\"', '\a', '<', '\x2', '\x2', 
		'\"', '\x4', '\x3', '\x2', '\x2', '\x2', '#', '$', '\a', '}', '\x2', '\x2', 
		'$', '\x6', '\x3', '\x2', '\x2', '\x2', '%', '&', '\a', '\x7F', '\x2', 
		'\x2', '&', '\b', '\x3', '\x2', '\x2', '\x2', '\'', '(', '\a', 'T', '\x2', 
		'\x2', '(', ')', '\a', '\x45', '\x2', '\x2', ')', '*', '\a', 'R', '\x2', 
		'\x2', '*', '+', '\a', '\x61', '\x2', '\x2', '+', ',', '\a', 'R', '\x2', 
		'\x2', ',', '-', '\a', '\x43', '\x2', '\x2', '-', '.', '\a', 'T', '\x2', 
		'\x2', '.', '/', '\a', '\x43', '\x2', '\x2', '/', '\x30', '\a', 'O', '\x2', 
		'\x2', '\x30', '\x31', '\a', '\x61', '\x2', '\x2', '\x31', '\x32', '\x3', 
		'\x2', '\x2', '\x2', '\x32', '\x33', '\x5', '\x1B', '\xE', '\x2', '\x33', 
		'\n', '\x3', '\x2', '\x2', '\x2', '\x34', '\x35', '\a', 'V', '\x2', '\x2', 
		'\x35', '\x36', '\a', '{', '\x2', '\x2', '\x36', '\x37', '\a', 'r', '\x2', 
		'\x2', '\x37', '\x38', '\a', 'g', '\x2', '\x2', '\x38', '\x39', '\a', 
		'<', '\x2', '\x2', '\x39', '\f', '\x3', '\x2', '\x2', '\x2', ':', ';', 
		'\a', 'L', '\x2', '\x2', ';', '<', '\a', 'U', '\x2', '\x2', '<', '=', 
		'\a', 'Q', '\x2', '\x2', '=', '>', '\a', 'P', '\x2', '\x2', '>', '?', 
		'\a', '\"', '\x2', '\x2', '?', '@', '\a', 'U', '\x2', '\x2', '@', '\x41', 
		'\a', 'w', '\x2', '\x2', '\x41', '\x42', '\a', 'r', '\x2', '\x2', '\x42', 
		'\x43', '\a', 'r', '\x2', '\x2', '\x43', '\x44', '\a', 'q', '\x2', '\x2', 
		'\x44', '\x45', '\a', 't', '\x2', '\x2', '\x45', '\x46', '\a', 'v', '\x2', 
		'\x2', '\x46', 'G', '\a', 'g', '\x2', '\x2', 'G', 'H', '\a', '\x66', '\x2', 
		'\x2', 'H', 'I', '\a', '\"', '\x2', '\x2', 'I', 'J', '\a', 'Q', '\x2', 
		'\x2', 'J', 'K', '\a', '\x64', '\x2', '\x2', 'K', 'L', '\a', 'l', '\x2', 
		'\x2', 'L', 'M', '\a', 'g', '\x2', '\x2', 'M', 'N', '\a', '\x65', '\x2', 
		'\x2', 'N', 'O', '\a', 'v', '\x2', '\x2', 'O', 'P', '\a', 'u', '\x2', 
		'\x2', 'P', 'Q', '\a', '<', '\x2', '\x2', 'Q', '\xE', '\x3', '\x2', '\x2', 
		'\x2', 'R', 'S', '\a', '\x63', '\x2', '\x2', 'S', 'T', '\a', 'p', '\x2', 
		'\x2', 'T', 'U', '\a', '\x66', '\x2', '\x2', 'U', 'V', '\a', '\x31', '\x2', 
		'\x2', 'V', 'W', '\a', 'q', '\x2', '\x2', 'W', 'X', '\a', 't', '\x2', 
		'\x2', 'X', '\x10', '\x3', '\x2', '\x2', '\x2', 'Y', 'Z', '\a', 'V', '\x2', 
		'\x2', 'Z', '[', '\a', '[', '\x2', '\x2', '[', '\\', '\a', 'R', '\x2', 
		'\x2', '\\', ']', '\a', 'G', '\x2', '\x2', ']', '^', '\a', 'U', '\x2', 
		'\x2', '^', '\x12', '\x3', '\x2', '\x2', '\x2', '_', '`', '\a', 't', '\x2', 
		'\x2', '`', '\x61', '\a', '\x65', '\x2', '\x2', '\x61', '\x62', '\a', 
		'r', '\x2', '\x2', '\x62', '\x63', '\a', '\x61', '\x2', '\x2', '\x63', 
		'\x65', '\x3', '\x2', '\x2', '\x2', '\x64', '\x66', '\x5', '\x1B', '\xE', 
		'\x2', '\x65', '\x64', '\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\x3', 
		'\x2', '\x2', '\x2', 'g', '\x65', '\x3', '\x2', '\x2', '\x2', 'g', 'h', 
		'\x3', '\x2', '\x2', '\x2', 'h', '\x14', '\x3', '\x2', '\x2', '\x2', 'i', 
		'k', '\a', '/', '\x2', '\x2', 'j', 'i', '\x3', '\x2', '\x2', '\x2', 'j', 
		'k', '\x3', '\x2', '\x2', '\x2', 'k', 'n', '\x3', '\x2', '\x2', '\x2', 
		'l', 'm', '\t', '\x2', '\x2', '\x2', 'm', 'o', '\t', '\x3', '\x2', '\x2', 
		'n', 'l', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\x3', '\x2', '\x2', '\x2', 
		'o', 'q', '\x3', '\x2', '\x2', '\x2', 'p', 'r', '\t', '\x4', '\x2', '\x2', 
		'q', 'p', '\x3', '\x2', '\x2', '\x2', 'r', 's', '\x3', '\x2', '\x2', '\x2', 
		's', 'q', '\x3', '\x2', '\x2', '\x2', 's', 't', '\x3', '\x2', '\x2', '\x2', 
		't', '{', '\x3', '\x2', '\x2', '\x2', 'u', 'w', '\v', '\x2', '\x2', '\x2', 
		'v', 'x', '\t', '\x4', '\x2', '\x2', 'w', 'v', '\x3', '\x2', '\x2', '\x2', 
		'x', 'y', '\x3', '\x2', '\x2', '\x2', 'y', 'w', '\x3', '\x2', '\x2', '\x2', 
		'y', 'z', '\x3', '\x2', '\x2', '\x2', 'z', '|', '\x3', '\x2', '\x2', '\x2', 
		'{', 'u', '\x3', '\x2', '\x2', '\x2', '{', '|', '\x3', '\x2', '\x2', '\x2', 
		'|', '\x16', '\x3', '\x2', '\x2', '\x2', '}', '~', '\a', 'v', '\x2', '\x2', 
		'~', '\x7F', '\a', 't', '\x2', '\x2', '\x7F', '\x80', '\a', 'w', '\x2', 
		'\x2', '\x80', '\x8E', '\a', 'g', '\x2', '\x2', '\x81', '\x82', '\a', 
		'h', '\x2', '\x2', '\x82', '\x83', '\a', '\x63', '\x2', '\x2', '\x83', 
		'\x84', '\a', 'n', '\x2', '\x2', '\x84', '\x85', '\a', 'u', '\x2', '\x2', 
		'\x85', '\x8E', '\a', 'g', '\x2', '\x2', '\x86', '\x87', '\a', 'p', '\x2', 
		'\x2', '\x87', '\x88', '\a', 'w', '\x2', '\x2', '\x88', '\x89', '\a', 
		'n', '\x2', '\x2', '\x89', '\x8E', '\a', 'n', '\x2', '\x2', '\x8A', '\x8B', 
		'\a', 'P', '\x2', '\x2', '\x8B', '\x8C', '\a', '\x63', '\x2', '\x2', '\x8C', 
		'\x8E', '\a', 'P', '\x2', '\x2', '\x8D', '}', '\x3', '\x2', '\x2', '\x2', 
		'\x8D', '\x81', '\x3', '\x2', '\x2', '\x2', '\x8D', '\x86', '\x3', '\x2', 
		'\x2', '\x2', '\x8D', '\x8A', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x18', 
		'\x3', '\x2', '\x2', '\x2', '\x8F', '\x93', '\a', '$', '\x2', '\x2', '\x90', 
		'\x92', '\n', '\x5', '\x2', '\x2', '\x91', '\x90', '\x3', '\x2', '\x2', 
		'\x2', '\x92', '\x95', '\x3', '\x2', '\x2', '\x2', '\x93', '\x91', '\x3', 
		'\x2', '\x2', '\x2', '\x93', '\x94', '\x3', '\x2', '\x2', '\x2', '\x94', 
		'\x96', '\x3', '\x2', '\x2', '\x2', '\x95', '\x93', '\x3', '\x2', '\x2', 
		'\x2', '\x96', '\x97', '\a', '$', '\x2', '\x2', '\x97', '\x1A', '\x3', 
		'\x2', '\x2', '\x2', '\x98', '\x9A', '\t', '\x6', '\x2', '\x2', '\x99', 
		'\x98', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x9B', '\x3', '\x2', '\x2', 
		'\x2', '\x9B', '\x99', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x9C', '\x3', 
		'\x2', '\x2', '\x2', '\x9C', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x9D', 
		'\x9F', '\a', '*', '\x2', '\x2', '\x9E', '\xA0', '\n', '\a', '\x2', '\x2', 
		'\x9F', '\x9E', '\x3', '\x2', '\x2', '\x2', '\xA0', '\xA1', '\x3', '\x2', 
		'\x2', '\x2', '\xA1', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xA1', '\x9F', 
		'\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', '\x3', '\x2', '\x2', '\x2', 
		'\xA3', '\xA4', '\a', '+', '\x2', '\x2', '\xA4', '\x1E', '\x3', '\x2', 
		'\x2', '\x2', '\xA5', '\xA7', '\t', '\b', '\x2', '\x2', '\xA6', '\xA5', 
		'\x3', '\x2', '\x2', '\x2', '\xA7', '\xA8', '\x3', '\x2', '\x2', '\x2', 
		'\xA8', '\xA6', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xA9', '\x3', '\x2', 
		'\x2', '\x2', '\xA9', '\xAA', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xAB', 
		'\b', '\x10', '\x2', '\x2', '\xAB', ' ', '\x3', '\x2', '\x2', '\x2', '\xE', 
		'\x2', 'g', 'j', 'n', 's', 'y', '{', '\x8D', '\x93', '\x9B', '\xA1', '\xA8', 
		'\x3', '\x2', '\x3', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
