//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System.Linq;
    using System;
    using System.Reflection;


	public enum EvexOpKind : byte 
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
		HX,
		HY,
		HZ,
		HXP3,
		HZP3,
		Ib,
		M,
		Rd,
		Rq,
		RX,
		RY,
		RZ,
		RK,
		VM32X,
		VM32Y,
		VM32Z,
		VM64X,
		VM64Y,
		VM64Z,
		VK,
		VKP1,
		VX,
		VY,
		VZ,
		WX,
		WY,
		WZ,
	}

}