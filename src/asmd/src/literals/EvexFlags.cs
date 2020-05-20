//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
	using System;

	[Flags]
	public enum EvexFlags : uint 
	{
		MandatoryPrefixByteMask = 0x00000003,
		MandatoryPrefixByteShift = 0x00000000,
		EvexOpCodeTableMask = 0x00000003,
		EvexOpCodeTableShift = 0x00000002,
		EncodableMask = 0x00000003,
		EncodableShift = 0x00000004,
		HasGroupIndex = 0x00000040,
		GroupShift = 0x00000007,
		EvexVectorLengthMask = 0x00000003,
		EvexVectorLengthShift = 0x0000000A,
		WBitMask = 0x00000003,
		WBitShift = 0x0000000C,
		TupleTypeMask = 0x0000003F,
		TupleTypeShift = 0x0000000E,
		LIG = 0x00100000,
		b = 0x00200000,
		er = 0x00400000,
		sae = 0x00800000,
		k1 = 0x01000000,
		z = 0x02000000,
		NonZeroOpMaskRegister = 0x04000000,
	}
}