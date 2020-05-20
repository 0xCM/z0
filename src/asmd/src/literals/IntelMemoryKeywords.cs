//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System;

	public enum IntelMemoryKeywords 
	{
		None,

		byte_ptr,

		dword_ptr,

		fpuenv14_ptr,

		fpuenv28_ptr,

		fpustate108_ptr,

		fpustate94_ptr,

		fword_ptr,

		qword_ptr,

		tbyte_ptr,

		word_ptr,

		xmmword_ptr,

		ymmword_ptr,

		zmmword_ptr,
	}
}