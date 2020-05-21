//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
	using System;

	[Flags,NumericBase(2,16)]
	public enum LegacyFlags : uint 
	{
		MandatoryPrefixByteMask = 0x00000003,
	
		MandatoryPrefixByteShift = 0x00000000,
	
		LegacyOpCodeTableMask = 0x00000003,
	
		LegacyOpCodeTableShift = 0x00000002,
	
		EncodableMask = 0x00000003,
	
		EncodableShift = 0x00000004,
	
		HasGroupIndex = 0x00000040,
	
		GroupShift = 0x00000007,
	
		AllowedPrefixesMask = 0x0000000F,
	
		AllowedPrefixesShift = 0x0000000A,
	
		Fwait = 0x00004000,
	
		HasMandatoryPrefix = 0x00008000,
	
		OperandSizeMask = 0x00000003,
	
		OperandSizeShift = 0x00000010,
	
		AddressSizeMask = 0x00000003,
	
		AddressSizeShift = 0x00000012,
	}
}