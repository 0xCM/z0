//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding 
{
    using System.Linq;
    using System;
    using System.Reflection;

	[Flags]
	public enum InstrInfoFlags : uint {
		None					= 0,
		SaveRestore				= 0x00000001,
		StackInstruction		= 0x00000002,
		ProtectedMode			= 0x00000004,
		Privileged				= 0x00000008,
		NoSegmentRead			= 0x00000010,
		AVX2_Check				= 0x00000020,
		OpMaskRegReadWrite		= 0x00000040,
	}

}