//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    public enum OpCodeHandlerKind : byte 
    {
        Bitness,
        
        Bitness_DontReadModRM,
        
        Invalid,
        
        Invalid_NoModRM,
        
        Invalid2,
        
        Dup,
        
        Null,
        
        HandlerReference,
        
        ArrayReference = 0x8,
        
        RM = 0x9,
        
        Options3,
        
        Options5,
        
        Options_DontReadModRM,
        
        AnotherTable,
        
        Group,
        
        Group8x64,
        
        Group8x8,
        
        MandatoryPrefix,
        
        MandatoryPrefix_F3_F2,
        
        LegacyMandatoryPrefix_F3_F2,
        
        MandatoryPrefix_NoModRM,
        
        MandatoryPrefix3,
        
        D3NOW,
        
        EVEX,
        
        VEX2,
        
        VEX3,
        
        XOP,
        
        AL_DX,
        
        Ap,
        
        B_BM,
        
        B_Ev,
        
        B_MIB,
        
        BM_B,
       
        BranchIw,
       
        BranchSimple,
       
        C_R_3a,
       
        C_R_3b,
       
        DX_AL,

        DX_eAX,

        eAX_DX,

        Eb_1,

        Eb_2,

        Eb_CL,

        Eb_Gb_1,

        Eb_Gb_2,

        Eb_Ib_1,

        Eb_Ib_2,

        Eb1,

        Ed_V_Ib,

        Ep,

        Ev_3a,

        Ev_3b,

        Ev_4,

        Ev_CL,

        Ev_Gv_32_64,

        Ev_Gv_3a,

        Ev_Gv_3b,

        Ev_Gv_4,

        Ev_Gv_CL,

        Ev_Gv_Ib,

        Ev_Gv_REX,

        Ev_Ib_3,

        Ev_Ib_4,

        Ev_Ib2_3,

        Ev_Ib2_4,

        Ev_Iz_3,

        Ev_Iz_4,

        Ev_P,

        Ev_REXW,

        Ev_Sw,
        Ev_VX,
        Ev1,
        Evj,
        Evw,
        Ew,
        Gb_Eb,
        Gdq_Ev,
        Gv_Eb,
        Gv_Eb_REX,
        Gv_Ev_32_64,
        Gv_Ev_3a,
        Gv_Ev_3b,
        Gv_Ev_Ib,
        Gv_Ev_Ib_REX,
        Gv_Ev_Iz,
        Gv_Ev_REX,
        Gv_Ev2,
        Gv_Ev3,
        Gv_Ew,
        Gv_M,
        Gv_M_as,
        Gv_Ma,
        Gv_Mp_2,
        Gv_Mp_3,
        Gv_Mv,
        Gv_N,
        Gv_N_Ib_REX,
        Gv_RX,
        Gv_W,
        GvM_VX_Ib,
        Ib,
        Ib3,
        IbReg,
        IbReg2,
        Iw_Ib,
        Jb,
        Jb2,
        Jdisp,
        Jx,
        Jz,
        M_1,
        M_2,
        M_REXW_2,
        M_REXW_4,
        MemBx,
        Mf_1,
        Mf_2a,
        Mf_2b,
        MIB_B,
        MP,
        Ms,
        MV,
        Mv_Gv,
        Mv_Gv_REXW,
        NIb,
        Ob_Reg,
        Ov_Reg,
        P_Ev,
        P_Ev_Ib,
        P_Q,
        P_Q_Ib,
        P_R,
        P_W,
        PushEv,
        PushIb2,
        PushIz,
        PushOpSizeReg_4a,
        PushOpSizeReg_4b,
        PushSimple2,
        PushSimpleReg,
        Q_P,
        R_C_3a,
        R_C_3b,
        rDI_P_N,
        rDI_VX_RX,
        Reg,
        Reg_Ib2,
        Reg_Iz,
        Reg_Ob,
        Reg_Ov,
        Reg_Xb,
        Reg_Xv,
        Reg_Xv2,
        Reg_Yb,
        Reg_Yv,
        RegIb,
        RegIb3,
        RegIz2,
        ReservedNop,
        RIb,
        RIbIb,
        Rv,
        Rv_32_64,
        RvMw_Gw,
        Simple,
        Simple_ModRM,
        Simple2_3a,
        Simple2_3b,
        Simple2Iw,
        Simple3,
        Simple4,
        Simple5,
        Simple5_ModRM_as,
        SimpleReg,
        ST_STi,
        STi,
        STi_ST,
        Sw_Ev,
        V_Ev,
        VM,
        VN,
        VQ,
        VRIbIb,
        VW_2,
        VW_3,
        VWIb_2,
        VWIb_3,
        VX_E_Ib,
        VX_Ev,
        Wbinvd,
        WV,
        Xb_Yb,
        Xchg_Reg_rAX,
        Xv_Yv,
        Yb_Reg,
        Yb_Xb,
        Yv_Reg,
        Yv_Reg2,
 
        Yv_Xv,
    }        
}