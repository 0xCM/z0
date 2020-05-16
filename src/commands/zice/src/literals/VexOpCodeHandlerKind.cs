//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;
	public enum VexOpCodeHandlerKind : byte 
    {
		Invalid,
		Invalid2,
		Dup,
		Invalid_NoModRM,
		Bitness_DontReadModRM,
		HandlerReference,
		ArrayReference,
		RM,
		Group,
		W,
		MandatoryPrefix2_1,
		MandatoryPrefix2_4,
		MandatoryPrefix2_NoModRM,
		VectorLength_NoModRM,
		VectorLength,
		Ed_V_Ib,
		Ev_VX,
		G_VK,
		Gv_Ev_Gv,
		Gv_Ev_Ib,
		Gv_Ev_Id,
		Gv_GPR_Ib,
		Gv_Gv_Ev,
		Gv_RX,
		Gv_W,
		GvM_VX_Ib,
		HRIb,
		Hv_Ed_Id,
		Hv_Ev,
		M,
		MHV,
		M_VK,
		MV,
		rDI_VX_RX,
		RdRq,
		Simple,
		VHEv,
		VHEvIb,
		VHIs4W,
		VHIs5W,
		VHM,
		VHW_2,
		VHW_3,
		VHW_4,
		VHWIb_2,
		VHWIb_4,
		VHWIs4,
		VHWIs5,
		VK_HK_RK,
		VK_R,
		VK_RK,
		VK_RK_Ib,
		VK_WK,
		VM,
		VW_2,
		VW_3,
		VWH,
		VWIb_2,
		VWIb_3,
		VX_Ev,
		VX_VSIB_HX,
		WHV,
		WV,
		WVIb,
	}
}