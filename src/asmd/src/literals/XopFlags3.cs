//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	[Flags]
	public enum XopFlags3 : uint 
	{
		OpMask = 0x0000001F,
		Op0Shift = 0x00000000,
		Op1Shift = 0x00000005,
		Op2Shift = 0x0000000A,
		Op3Shift = 0x0000000F,
	}
}