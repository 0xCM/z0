//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IOpCodeHandler : INullaryKnown
    {
        OpCodeId[] Codes {get;}

        Register[] Registers {get;}

    }

    readonly struct RexHandler : IOpCodeHandler
    {
        [MethodImpl(Inline)]
        public static RexHandler Define(bool allowReg, bool allowMem, Register[] registers, params OpCodeId[] codes)
            => new RexHandler(codes,registers, allowReg, allowMem);

        [MethodImpl(Inline)]
        public static RexHandler Define(bool allowReg, bool allowMem, params OpCodeId[] codes)
            => new RexHandler(codes,Control.array<Register>(), allowReg, allowMem);

        public readonly bool AllowReg;
        
        public readonly bool AllowMem;
        
        public OpCodeId[] Codes {get;}

        public Register[] Registers {get;}

        [MethodImpl(Inline)]
        public RexHandler(OpCodeId[] code, Register[] registers, bool allowReg, bool allowMem)
        {
            Codes = code;
            Registers = registers;
            AllowReg = allowReg;
            AllowMem = allowMem;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Codes == null || Codes.Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }

    readonly struct OpCodeHandler : IOpCodeHandler
    {
        public static OpCodeHandler Empty => new OpCodeHandler(Control.array<OpCodeId>());

        public OpCodeId[] Codes {get;}

        public Register[] Registers {get;}

        public readonly HandlerFlags Flags;

        [MethodImpl(Inline)]
        public static OpCodeHandler Define(params OpCodeId[] codes)
            => new OpCodeHandler(codes);

        [MethodImpl(Inline)]
        public static OpCodeHandler Define(HandlerFlags flags, params OpCodeId[] codes)
            => new OpCodeHandler(codes, flags);

        [MethodImpl(Inline)]
        public static OpCodeHandler Define(Register r, params OpCodeId[] codes)
            => new OpCodeHandler(codes, Control.array(r));

        [MethodImpl(Inline)]
        public OpCodeHandler(OpCodeId[] code, HandlerFlags flags = default)
        {
            Codes = code;
            Registers = Control.array<Register>();
            Flags = flags;
        }

        [MethodImpl(Inline)]
        public OpCodeHandler(OpCodeId[] code, Register[] registers, HandlerFlags flags = default)
        {
            Codes = code;
            Registers = registers;
            Flags = flags;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Codes == null || Codes.Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }

	readonly struct HandlerInfo 
    {
		public readonly IOpCodeHandler Handler;
		
        public readonly IOpCodeHandler[] Handlers;

		public HandlerInfo(IOpCodeHandler handler) 
        {
			Handler = handler;
			Handlers = Control.array<IOpCodeHandler>();
		}

		public HandlerInfo(IOpCodeHandler[] handlers) 
        {
			Handler = OpCodeHandler.Empty;
			Handlers = handlers;
		}
	}

	[Flags]
	enum HandlerFlags : uint 
    {
		None = 0x00000000,
		Xacquire = 0x00000001,
		Xrelease = 0x00000002,
		XacquireXreleaseNoLock = 0x00000004,
		Lock = 0x00000008,
	}

       enum OpCodeHandlerKind : byte 
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


	enum VexOpCodeHandlerKind : byte {
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