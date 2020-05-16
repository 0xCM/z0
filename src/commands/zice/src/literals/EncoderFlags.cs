//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
	using System;

	[Flags]
	public enum EncoderFlags : uint 
	{
		None = 0x00000000,
		B = 0x00000001,
		X = 0x00000002,
		R = 0x00000004,
		W = 0x00000008,
		ModRM = 0x00000010,
		Sib = 0x00000020,
		REX = 0x00000040,
		P66 = 0x00000080,
		P67 = 0x00000100,
		/// <summary><c>EVEX.R&apos;</c></summary>
		R2 = 0x00000200,
		Broadcast = 0x00000400,
		HighLegacy8BitRegs = 0x00000800,
		Displ = 0x00001000,
		PF0 = 0x00002000,
		RegIsMemory = 0x00004000,
		VvvvvShift = 0x0000001B,
		VvvvvMask = 0x0000001F,
	}


}