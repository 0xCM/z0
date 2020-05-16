//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	[Flags]
	public enum EncFlags1 : uint 
	{
		EncodingShift = 0x00000000,
		EncodingMask = 0x00000007,
		OpCodeShift = 0x00000010,
	}

}