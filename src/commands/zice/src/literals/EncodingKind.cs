//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System;

	public enum EncodingKind 
    {
		[Comment("Legacy encoding")]
		Legacy,
		[Comment("VEX encoding")]
		VEX,
		[Comment("EVEX encoding")]
		EVEX,
		[Comment("XOP encoding")]
		XOP,
		[Comment("3DNow! encoding")]
		D3NOW,
	}
}