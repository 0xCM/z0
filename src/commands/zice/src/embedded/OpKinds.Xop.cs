//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Reflection;
	using System.Linq;

	partial class EmbeddedData 
	{
		public static System.ReadOnlySpan<byte> XopOpKinds => new byte[19] {
			(byte)OpCodeOperandKind.None,// None
			(byte)OpCodeOperandKind.r32_or_mem,// Ed
			(byte)OpCodeOperandKind.r64_or_mem,// Eq
			(byte)OpCodeOperandKind.r32_reg,// Gd
			(byte)OpCodeOperandKind.r64_reg,// Gq
			(byte)OpCodeOperandKind.r32_rm,// Rd
			(byte)OpCodeOperandKind.r64_rm,// Rq
			(byte)OpCodeOperandKind.r32_vvvv,// Hd
			(byte)OpCodeOperandKind.r64_vvvv,// Hq
			(byte)OpCodeOperandKind.xmm_vvvv,// HX
			(byte)OpCodeOperandKind.ymm_vvvv,// HY
			(byte)OpCodeOperandKind.imm8,// Ib
			(byte)OpCodeOperandKind.imm32,// Id
			(byte)OpCodeOperandKind.xmm_is4,// Is4X
			(byte)OpCodeOperandKind.ymm_is4,// Is4Y
			(byte)OpCodeOperandKind.xmm_reg,// VX
			(byte)OpCodeOperandKind.ymm_reg,// VY
			(byte)OpCodeOperandKind.xmm_or_mem,// WX
			(byte)OpCodeOperandKind.ymm_or_mem,// WY
		};
    }
}