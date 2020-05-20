//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	[Flags]
	public enum VexFlags3 : uint 
	{
		OpMask = 0x0000003F,
		
		Op0Shift = 0x00000000,
		
		Op1Shift = 0x00000006,
		
		Op2Shift = 0x0000000C,
		
		Op3Shift = 0x00000012,
		
		Op4Shift = 0x00000018,
	}
}