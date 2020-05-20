//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System;
	public enum LegacyOpKind : byte 
    {
		None,
		
		Aww,
		
		Adw,
		
		M,
		
		Mfbcd,
		
		Mf32,
		
		Mf64,
		
		Mf80,
		
		Mfi16,
		
		Mfi32,
		
		Mfi64,
		
		M14,
		
		M28,
		
		M98,
		
		M108,
		
		Mp,
		
		Ms,
		
		Mo,
		
		Mb,
		
		Mw,
		
		Md,
		Md_MPX,
		Mq,
		Mq_MPX,
		Mw2,
		Md2,
		Eb,
		Ew,
		Ed,
		Ed_MPX,
		Ew_d,
		Ew_q,
		Eq,
		Eq_MPX,
		Eww,
		Edw,
		Eqw,
		RdMb,
		RqMb,
		RdMw,
		RqMw,
		Gb,
		Gw,
		Gd,
		Gq,
		Gw_mem,
		Gd_mem,
		Gq_mem,
		Rw,
		Rd,
		Rq,
		Sw,
		Cd,
		Cq,
		Dd,
		Dq,
		Td,
		Ib,
		Ib16,
		Ib32,
		Ib64,
		Iw,
		Id,
		Id64,
		Iq,
		Ib21,
		Ib11,
		Xb,
		Xw,
		Xd,
		Xq,
		Yb,
		Yw,
		Yd,
		Yq,
		wJb,
		dJb,
		qJb,
		Jw,
		wJd,
		dJd,
		qJd,
		Jxw,
		Jxd,
		Jdisp16,
		Jdisp32,
		Ob,
		Ow,
		Od,
		Oq,
		Imm1,
		B,
		BMq,
		BMo,
		MIB,
		N,
		P,
		Q,
		RX,
		VX,
		WX,
		rDI,
		MRBX,
		ES,
		CS,
		SS,
		DS,
		FS,
		GS,
		AL,
		CL,
		AX,
		DX,
		EAX,
		RAX,
		ST,
		STi,
		r8_rb,
		r16_rw,
		r32_rd,
		r64_ro,
	}
}