//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
	using System;

	[Flags]
	public enum LegacyFlags3 : uint 
	{
		OpMask = 0x0000007F,
		Op0Shift = 0x00000000,
		Op1Shift = 0x00000007,
		Op2Shift = 0x0000000E,
		Op3Shift = 0x00000015,
	}

}