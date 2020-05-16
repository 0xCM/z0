//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System.Linq;
    using System;
    using System.Reflection;

	public enum VexOpKind : byte 
    {
		None,
		Ed,
		Eq,
		Gd,
		Gq,
		RdMb,
		RqMb,
		RdMw,
		RqMw,
		Rd,
		Rq,
		Hd,
		Hq,
		HK,
		HX,
		HY,
		Ib,
		I2,
		Is4X,
		Is4Y,
		Is5X,
		Is5Y,
		M,
		Md,
		MK,
		rDI,
		RK,
		RX,
		RY,
		VK,
		VM32X,
		VM32Y,
		VM64X,
		VM64Y,
		VX,
		VY,
		WK,
		WX,
		WY,
	}

}