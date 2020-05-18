//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
		
	[Flags]
	public enum D3nowFlags : uint 
	{
		EncodableMask = 0x00000003,
		EncodableShift = 0x00000000,
	}

}