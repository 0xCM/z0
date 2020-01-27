//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.AsmSpecs 
{
	/// <summary>
	/// Formatter text kind
	/// </summary>
	public enum FormatterOutputTextKind 
    {
		/// <summary>
		/// Normal text
		/// </summary>
		Text,

		/// <summary>
		/// Assembler directive
		/// </summary>
		Directive,

		/// <summary>
		/// Any prefix
		/// </summary>
		Prefix,

		/// <summary>
		/// Any mnemonic
		/// </summary>
		Mnemonic,

		/// <summary>
		/// Any keyword
		/// </summary>
		Keyword,

		/// <summary>
		/// Any operator
		/// </summary>
		Operator,

		/// <summary>
		/// Any punctuation
		/// </summary>
		Punctuation,

		/// <summary>
		/// Number
		/// </summary>
		Number,

		/// <summary>
		/// Any register
		/// </summary>
		Register,

		/// <summary>
		/// A decorator, eg. 'sae' in '{sae}'
		/// </summary>
		Decorator,

		/// <summary>
		/// Selector value (eg. far jmp/call)
		/// </summary>
		SelectorValue,

		/// <summary>
		/// Label address (eg. JE XXXXXX)
		/// </summary>
		LabelAddress,

		/// <summary>
		/// Function address (eg. CALL XXXXX)
		/// </summary>
		FunctionAddress,

		/// <summary>
		/// Data symbol
		/// </summary>
		Data,

		/// <summary>
		/// Label symbol
		/// </summary>
		Label,

		/// <summary>
		/// Function symbol
		/// </summary>
		Function,
	}
}
