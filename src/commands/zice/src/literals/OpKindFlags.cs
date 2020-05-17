//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	/// <summary>
	/// [4:0]	= Operand #0's <c>OpKind</c>
	/// [9:5]	= Operand #1's <c>OpKind</c>
	/// [14:10]	= Operand #2's <c>OpKind</c>
	/// [19:15]	= Operand #3's <c>OpKind</c>
	/// [23:20]	= db/dw/dd/dq element count (1-16, 1-8, 1-4, or 1-2)
	/// [29:24]	= Not used
	/// [31:30]	= CodeSize
	/// </summary>
	[Flags, NumericBase(2)]
	public enum OpKindFlags : uint 
	{
		OpKindBits				= 5,
		
        OpKindMask				= (1 << (int)OpKindBits) - 1,
		
        Op1KindShift			= 5,
		
        Op2KindShift			= 10,
		
        Op3KindShift			= 15,
		
        DataLengthMask			= 0xF,
		
        DataLengthShift			= 20,
		
        // Unused bits here
		CodeSizeMask			= 3,
		
        CodeSizeShift			= 30,

		// Bits ignored by Equals()
		EqualsIgnoreMask		= CodeSizeMask << (int)CodeSizeShift,
	}

}