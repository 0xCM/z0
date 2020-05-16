//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding 
{
    using System.Linq;
    using System;
    using System.Reflection;

	public enum XopOpKind : byte {
		None,
		Ed,
		Eq,
		Gd,
		Gq,
		Rd,
		Rq,
		Hd,
		Hq,
		HX,
		HY,
		Ib,
		Id,
		Is4X,
		Is4Y,
		VX,
		VY,
		WX,
		WY,
	}

}