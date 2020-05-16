//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System.Linq;
    using System;
    using System.Reflection;
	public enum OpCodeTableKind {
		[Comment("Legacy encoding table")]
		Normal,

		[Comment("#(c:0Fxx)# table (legacy, VEX, EVEX)")]
		T0F,

		[Comment("#(c:0F38xx)# table (legacy, VEX, EVEX)")]
		T0F38,

		[Comment("#(c:0F3Axx)# table (legacy, VEX, EVEX)")]
		T0F3A,

		[Comment("#(c:XOP8)# table (XOP)")]
		XOP8,

		[Comment("#(c:XOP9)# table (XOP)")]
		XOP9,

		[Comment("#(c:XOPA)# table (XOP)")]
		XOPA,
	}
}