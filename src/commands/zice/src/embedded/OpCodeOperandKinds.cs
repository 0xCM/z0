//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Reflection;
	using System.Linq;

	public static class OpCodeOperandKinds {
		public static System.ReadOnlySpan<byte> LegacyOpKinds => new byte[121] {
			(byte)OpCodeOperandKind.None,// None
			(byte)OpCodeOperandKind.farbr2_2,// Aww
			(byte)OpCodeOperandKind.farbr4_2,// Adw
			(byte)OpCodeOperandKind.mem,// M
			(byte)OpCodeOperandKind.mem,// Mfbcd
			(byte)OpCodeOperandKind.mem,// Mf32
			(byte)OpCodeOperandKind.mem,// Mf64
			(byte)OpCodeOperandKind.mem,// Mf80
			(byte)OpCodeOperandKind.mem,// Mfi16
			(byte)OpCodeOperandKind.mem,// Mfi32
			(byte)OpCodeOperandKind.mem,// Mfi64
			(byte)OpCodeOperandKind.mem,// M14
			(byte)OpCodeOperandKind.mem,// M28
			(byte)OpCodeOperandKind.mem,// M98
			(byte)OpCodeOperandKind.mem,// M108
			(byte)OpCodeOperandKind.mem,// Mp
			(byte)OpCodeOperandKind.mem,// Ms
			(byte)OpCodeOperandKind.mem,// Mo
			(byte)OpCodeOperandKind.mem,// Mb
			(byte)OpCodeOperandKind.mem,// Mw
			(byte)OpCodeOperandKind.mem,// Md
			(byte)OpCodeOperandKind.mem_mpx,// Md_MPX
			(byte)OpCodeOperandKind.mem,// Mq
			(byte)OpCodeOperandKind.mem_mpx,// Mq_MPX
			(byte)OpCodeOperandKind.mem,// Mw2
			(byte)OpCodeOperandKind.mem,// Md2
			(byte)OpCodeOperandKind.r8_or_mem,// Eb
			(byte)OpCodeOperandKind.r16_or_mem,// Ew
			(byte)OpCodeOperandKind.r32_or_mem,// Ed
			(byte)OpCodeOperandKind.r32_or_mem_mpx,// Ed_MPX
			(byte)OpCodeOperandKind.r32_or_mem,// Ew_d
			(byte)OpCodeOperandKind.r64_or_mem,// Ew_q
			(byte)OpCodeOperandKind.r64_or_mem,// Eq
			(byte)OpCodeOperandKind.r64_or_mem_mpx,// Eq_MPX
			(byte)OpCodeOperandKind.mem,// Eww
			(byte)OpCodeOperandKind.mem,// Edw
			(byte)OpCodeOperandKind.mem,// Eqw
			(byte)OpCodeOperandKind.r32_or_mem,// RdMb
			(byte)OpCodeOperandKind.r64_or_mem,// RqMb
			(byte)OpCodeOperandKind.r32_or_mem,// RdMw
			(byte)OpCodeOperandKind.r64_or_mem,// RqMw
			(byte)OpCodeOperandKind.r8_reg,// Gb
			(byte)OpCodeOperandKind.r16_reg,// Gw
			(byte)OpCodeOperandKind.r32_reg,// Gd
			(byte)OpCodeOperandKind.r64_reg,// Gq
			(byte)OpCodeOperandKind.r16_reg_mem,// Gw_mem
			(byte)OpCodeOperandKind.r32_reg_mem,// Gd_mem
			(byte)OpCodeOperandKind.r64_reg_mem,// Gq_mem
			(byte)OpCodeOperandKind.r16_rm,// Rw
			(byte)OpCodeOperandKind.r32_rm,// Rd
			(byte)OpCodeOperandKind.r64_rm,// Rq
			(byte)OpCodeOperandKind.seg_reg,// Sw
			(byte)OpCodeOperandKind.cr_reg,// Cd
			(byte)OpCodeOperandKind.cr_reg,// Cq
			(byte)OpCodeOperandKind.dr_reg,// Dd
			(byte)OpCodeOperandKind.dr_reg,// Dq
			(byte)OpCodeOperandKind.tr_reg,// Td
			(byte)OpCodeOperandKind.imm8,// Ib
			(byte)OpCodeOperandKind.imm8sex16,// Ib16
			(byte)OpCodeOperandKind.imm8sex32,// Ib32
			(byte)OpCodeOperandKind.imm8sex64,// Ib64
			(byte)OpCodeOperandKind.imm16,// Iw
			(byte)OpCodeOperandKind.imm32,// Id
			(byte)OpCodeOperandKind.imm32sex64,// Id64
			(byte)OpCodeOperandKind.imm64,// Iq
			(byte)OpCodeOperandKind.imm8,// Ib21
			(byte)OpCodeOperandKind.imm8,// Ib11
			(byte)OpCodeOperandKind.seg_rSI,// Xb
			(byte)OpCodeOperandKind.seg_rSI,// Xw
			(byte)OpCodeOperandKind.seg_rSI,// Xd
			(byte)OpCodeOperandKind.seg_rSI,// Xq
			(byte)OpCodeOperandKind.es_rDI,// Yb
			(byte)OpCodeOperandKind.es_rDI,// Yw
			(byte)OpCodeOperandKind.es_rDI,// Yd
			(byte)OpCodeOperandKind.es_rDI,// Yq
			(byte)OpCodeOperandKind.br16_1,// wJb
			(byte)OpCodeOperandKind.br32_1,// dJb
			(byte)OpCodeOperandKind.br64_1,// qJb
			(byte)OpCodeOperandKind.br16_2,// Jw
			(byte)OpCodeOperandKind.br32_4,// wJd
			(byte)OpCodeOperandKind.br32_4,// dJd
			(byte)OpCodeOperandKind.br64_4,// qJd
			(byte)OpCodeOperandKind.xbegin_2,// Jxw
			(byte)OpCodeOperandKind.xbegin_4,// Jxd
			(byte)OpCodeOperandKind.brdisp_2,// Jdisp16
			(byte)OpCodeOperandKind.brdisp_4,// Jdisp32
			(byte)OpCodeOperandKind.mem_offs,// Ob
			(byte)OpCodeOperandKind.mem_offs,// Ow
			(byte)OpCodeOperandKind.mem_offs,// Od
			(byte)OpCodeOperandKind.mem_offs,// Oq
			(byte)OpCodeOperandKind.imm8_const_1,// Imm1
			(byte)OpCodeOperandKind.bnd_reg,// B
			(byte)OpCodeOperandKind.bnd_or_mem_mpx,// BMq
			(byte)OpCodeOperandKind.bnd_or_mem_mpx,// BMo
			(byte)OpCodeOperandKind.mem_mib,// MIB
			(byte)OpCodeOperandKind.mm_rm,// N
			(byte)OpCodeOperandKind.mm_reg,// P
			(byte)OpCodeOperandKind.mm_or_mem,// Q
			(byte)OpCodeOperandKind.xmm_rm,// RX
			(byte)OpCodeOperandKind.xmm_reg,// VX
			(byte)OpCodeOperandKind.xmm_or_mem,// WX
			(byte)OpCodeOperandKind.seg_rDI,// rDI
			(byte)OpCodeOperandKind.seg_rBX_al,// MRBX
			(byte)OpCodeOperandKind.es,// ES
			(byte)OpCodeOperandKind.cs,// CS
			(byte)OpCodeOperandKind.ss,// SS
			(byte)OpCodeOperandKind.ds,// DS
			(byte)OpCodeOperandKind.fs,// FS
			(byte)OpCodeOperandKind.gs,// GS
			(byte)OpCodeOperandKind.al,// AL
			(byte)OpCodeOperandKind.cl,// CL
			(byte)OpCodeOperandKind.ax,// AX
			(byte)OpCodeOperandKind.dx,// DX
			(byte)OpCodeOperandKind.eax,// EAX
			(byte)OpCodeOperandKind.rax,// RAX
			(byte)OpCodeOperandKind.st0,// ST
			(byte)OpCodeOperandKind.sti_opcode,// STi
			(byte)OpCodeOperandKind.r8_opcode,// r8_rb
			(byte)OpCodeOperandKind.r16_opcode,// r16_rw
			(byte)OpCodeOperandKind.r32_opcode,// r32_rd
			(byte)OpCodeOperandKind.r64_opcode,// r64_ro
		};

		public static System.ReadOnlySpan<byte> VexOpKinds => new byte[39] {
			(byte)OpCodeOperandKind.None,// None
			(byte)OpCodeOperandKind.r32_or_mem,// Ed
			(byte)OpCodeOperandKind.r64_or_mem,// Eq
			(byte)OpCodeOperandKind.r32_reg,// Gd
			(byte)OpCodeOperandKind.r64_reg,// Gq
			(byte)OpCodeOperandKind.r32_or_mem,// RdMb
			(byte)OpCodeOperandKind.r64_or_mem,// RqMb
			(byte)OpCodeOperandKind.r32_or_mem,// RdMw
			(byte)OpCodeOperandKind.r64_or_mem,// RqMw
			(byte)OpCodeOperandKind.r32_rm,// Rd
			(byte)OpCodeOperandKind.r64_rm,// Rq
			(byte)OpCodeOperandKind.r32_vvvv,// Hd
			(byte)OpCodeOperandKind.r64_vvvv,// Hq
			(byte)OpCodeOperandKind.k_vvvv,// HK
			(byte)OpCodeOperandKind.xmm_vvvv,// HX
			(byte)OpCodeOperandKind.ymm_vvvv,// HY
			(byte)OpCodeOperandKind.imm8,// Ib
			(byte)OpCodeOperandKind.imm2_m2z,// I2
			(byte)OpCodeOperandKind.xmm_is4,// Is4X
			(byte)OpCodeOperandKind.ymm_is4,// Is4Y
			(byte)OpCodeOperandKind.xmm_is5,// Is5X
			(byte)OpCodeOperandKind.ymm_is5,// Is5Y
			(byte)OpCodeOperandKind.mem,// M
			(byte)OpCodeOperandKind.mem,// Md
			(byte)OpCodeOperandKind.mem,// MK
			(byte)OpCodeOperandKind.seg_rDI,// rDI
			(byte)OpCodeOperandKind.k_rm,// RK
			(byte)OpCodeOperandKind.xmm_rm,// RX
			(byte)OpCodeOperandKind.ymm_rm,// RY
			(byte)OpCodeOperandKind.k_reg,// VK
			(byte)OpCodeOperandKind.mem_vsib32x,// VM32X
			(byte)OpCodeOperandKind.mem_vsib32y,// VM32Y
			(byte)OpCodeOperandKind.mem_vsib64x,// VM64X
			(byte)OpCodeOperandKind.mem_vsib64y,// VM64Y
			(byte)OpCodeOperandKind.xmm_reg,// VX
			(byte)OpCodeOperandKind.ymm_reg,// VY
			(byte)OpCodeOperandKind.k_or_mem,// WK
			(byte)OpCodeOperandKind.xmm_or_mem,// WX
			(byte)OpCodeOperandKind.ymm_or_mem,// WY
		};
#if HAS_SPAN
		public static System.ReadOnlySpan<byte> XopOpKinds => new byte[19] {
#else
		public static readonly byte[] XopOpKinds = new byte[19] {
#endif
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
#if HAS_SPAN
		public static System.ReadOnlySpan<byte> EvexOpKinds => new byte[36] {
#else
		public static readonly byte[] EvexOpKinds = new byte[36] {
#endif
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