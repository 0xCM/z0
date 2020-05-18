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
		public static System.ReadOnlySpan<byte> EvexOpKinds => new byte[36] {
			(byte)OpCodeOperandKind.None,// None
			(byte)OpCodeOperandKind.r32_or_mem,// Ed
			(byte)OpCodeOperandKind.r64_or_mem,// Eq
			(byte)OpCodeOperandKind.r32_reg,// Gd
			(byte)OpCodeOperandKind.r64_reg,// Gq
			(byte)OpCodeOperandKind.r32_or_mem,// RdMb
			(byte)OpCodeOperandKind.r64_or_mem,// RqMb
			(byte)OpCodeOperandKind.r32_or_mem,// RdMw
			(byte)OpCodeOperandKind.r64_or_mem,// RqMw
			(byte)OpCodeOperandKind.xmm_vvvv,// HX
			(byte)OpCodeOperandKind.ymm_vvvv,// HY
			(byte)OpCodeOperandKind.zmm_vvvv,// HZ
			(byte)OpCodeOperandKind.xmmp3_vvvv,// HXP3
			(byte)OpCodeOperandKind.zmmp3_vvvv,// HZP3
			(byte)OpCodeOperandKind.imm8,// Ib
			(byte)OpCodeOperandKind.mem,// M
			(byte)OpCodeOperandKind.r32_rm,// Rd
			(byte)OpCodeOperandKind.r64_rm,// Rq
			(byte)OpCodeOperandKind.xmm_rm,// RX
			(byte)OpCodeOperandKind.ymm_rm,// RY
			(byte)OpCodeOperandKind.zmm_rm,// RZ
			(byte)OpCodeOperandKind.k_rm,// RK
			(byte)OpCodeOperandKind.mem_vsib32x,// VM32X
			(byte)OpCodeOperandKind.mem_vsib32y,// VM32Y
			(byte)OpCodeOperandKind.mem_vsib32z,// VM32Z
			(byte)OpCodeOperandKind.mem_vsib64x,// VM64X
			(byte)OpCodeOperandKind.mem_vsib64y,// VM64Y
			(byte)OpCodeOperandKind.mem_vsib64z,// VM64Z
			(byte)OpCodeOperandKind.k_reg,// VK
			(byte)OpCodeOperandKind.kp1_reg,// VKP1
			(byte)OpCodeOperandKind.xmm_reg,// VX
			(byte)OpCodeOperandKind.ymm_reg,// VY
			(byte)OpCodeOperandKind.zmm_reg,// VZ
			(byte)OpCodeOperandKind.xmm_or_mem,// WX
			(byte)OpCodeOperandKind.ymm_or_mem,// WY
			(byte)OpCodeOperandKind.zmm_or_mem,// WZ
		};
    }
}