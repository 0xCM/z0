//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
	using System;

	[Flags]
	public enum OpCodeHandlerFlags : uint 
	{
		None = 0x00000000,
		
		Fwait = 0x00000001,
		
		DeclareData = 0x00000002,
	}
}