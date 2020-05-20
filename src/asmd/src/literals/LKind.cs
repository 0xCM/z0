//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	public enum LKind : byte 
	{
		None,

		[Comment(".128, .256, .512")]
		L128,

		[Comment(".L0, .L1")]
		L0,
		
		[Comment(".LZ")]
		LZ,

	}
}