//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	public enum DisplSize 
    {
		None,
		Size1,
		Size2,
		Size4,
		Size8,
		RipRelSize4_Target32,
		RipRelSize4_Target64,
	}

}