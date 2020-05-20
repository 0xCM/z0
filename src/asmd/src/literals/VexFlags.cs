//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
	using System;
	
	[Flags]
	public enum VexFlags : uint 
	{
		MandatoryPrefixByteMask = 0x00000003,

		MandatoryPrefixByteShift = 0x00000000,

		VexOpCodeTableMask = 0x00000003,

		VexOpCodeTableShift = 0x00000002,

		EncodableMask = 0x00000003,

		EncodableShift = 0x00000004,

		HasGroupIndex = 0x00000040,

		GroupShift = 0x00000007,

		VexVectorLengthMask = 0x00000007,

		VexVectorLengthShift = 0x0000000A,

		WBitMask = 0x00000003,

		WBitShift = 0x0000000D,
	}
}