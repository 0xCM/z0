//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	/// <summary>
	/// [1:0]	= Scale
	/// [4:2]	= Size of displacement: 0, 1, 2, 4, 8
	/// [7:5]	= Segment register prefix: none, es, cs, ss, ds, fs, gs, reserved
	/// [14:8]	= Not used
	/// [15]	= Broadcasted memory
	/// </summary>
	[Flags, NumericBase(2)]
	public enum MemoryFlags : ushort 
	{
		ScaleMask				= 3,
	
    	DisplSizeShift			= 2,
	
    	DisplSizeMask			= 7,
	
    	SegmentPrefixShift		= 5,
	
    	SegmentPrefixMask		= 7,
	
    	// Unused bits here
		Broadcast				= 0x8000,
	}
}