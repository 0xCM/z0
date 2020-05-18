//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
	using System;

	public enum ImmSize 
	{
		None,
		Size1,
		Size2,
		Size4,
		Size8,
		/// <summary><c>ENTER xxxx,yy</c></summary>
		Size2_1,
		/// <summary><c>EXTRQ/INSERTQ xx,yy</c></summary>
		Size1_1,
		/// <summary><c>CALL16 FAR x:y</c></summary>
		Size2_2,
		/// <summary><c>CALL32 FAR x:y</c></summary>
		Size4_2,
		RipRelSize1_Target16,
		RipRelSize1_Target32,
		RipRelSize1_Target64,
		RipRelSize2_Target16,
		RipRelSize2_Target32,
		RipRelSize2_Target64,
		RipRelSize4_Target32,
		RipRelSize4_Target64,
		SizeIbReg,
		Size1OpCode,
	}
}