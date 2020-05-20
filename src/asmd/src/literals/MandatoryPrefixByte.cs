//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
	
	public enum MandatoryPrefixByte : uint 
    {
		None,
		
		P66,
		
		PF3,
		
		PF2,
	}
}