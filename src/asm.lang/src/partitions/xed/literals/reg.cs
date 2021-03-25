//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-reg-enum.h
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct XedModels
    {
        [SymbolSource]
        public enum RegId : ushort
        {
            None,

            BNDCFGU,

            BNDSTATUS,

            BND0,

            BND1,

            BND2,

            BND3,

            CR0,

            CR1,

            CR2,

            CR3,

            CR4,

            CR5,

            CR6,

            CR7,

            CR8,

            CR9,

            CR10,

            CR11,

            CR12,

            CR13,

            CR14,

            CR15,

            DR0,

            DR1,

            DR2,

            DR3,

            DR4,

            DR5,

            DR6,

            DR7,

            FLAGS,

            EFLAGS,

            RFLAGS,

            AX,

            CX,

            DX,

            BX,

            SP,

            BP,

            SI,

            DI,

            R8W,

            R9W,

            R10W,

            R11W,

            R12W,

            R13W,

            R14W,

            R15W,

            EAX,

            ECX,

            EDX,

            EBX,

            ESP,

            EBP,

            ESI,

            EDI,

            R8D,

            R9D,

            R10D,

            R11D,

            R12D,

            R13D,

            R14D,

            R15D,

            RAX,

            RCX,

            RDX,

            RBX,

            RSP,

            RBP,

            RSI,

            RDI,

            R8,

            R9,

            R10,

            R11,

            R12,

            R13,

            R14,

            R15,

            AL,

            CL,

            DL,

            BL,

            SPL,

            BPL,

            SIL,

            DIL,

            R8B,

            R9B,

            R10B,

            R11B,

            R12B,

            R13B,

            R14B,

            R15B,

            AH,

            CH,

            DH,

            BH,

            ERROR,

            RIP,

            EIP,

            IP,

            K0,

            K1,

            K2,

            K3,

            K4,

            K5,

            K6,

            K7,

            MMX0,

            MMX1,

            MMX2,

            MMX3,

            MMX4,

            MMX5,

            MMX6,

            MMX7,

            SSP,

            IA32_U_CET,

            MXCSR,

            STACKPUSH,

            STACKPOP,

            GDTR,

            LDTR,

            IDTR,

            TR,

            TSC,

            TSCAUX,

            MSRS,

            FSBASE,

            GSBASE,

            TILECONFIG,

            X87CONTROL,

            X87STATUS,

            X87TAG,

            X87PUSH,

            X87POP,

            X87POP2,

            X87OPCODE,

            X87LASTCS,

            X87LASTIP,

            X87LASTDS,

            X87LASTDP,

            ES,

            CS,

            SS,

            DS,

            FS,

            GS,

            TMP0,

            TMP1,

            TMP2,

            TMP3,

            TMP4,

            TMP5,

            TMP6,

            TMP7,

            TMP8,

            TMP9,

            TMP10,

            TMP11,

            TMP12,

            TMP13,

            TMP14,

            TMP15,

            TMM0,

            TMM1,

            TMM2,

            TMM3,

            TMM4,

            TMM5,

            TMM6,

            TMM7,
            UIF,
            ST0,
            ST1,
            ST2,
            ST3,
            ST4,
            ST5,
            ST6,
            ST7,
            XCR0,
            XMM0,
            XMM1,
            XMM2,
            XMM3,
            XMM4,
            XMM5,
            XMM6,
            XMM7,
            XMM8,
            XMM9,
            XMM10,
            XMM11,
            XMM12,
            XMM13,
            XMM14,
            XMM15,
            XMM16,
            XMM17,
            XMM18,
            XMM19,
            XMM20,
            XMM21,
            XMM22,
            XMM23,
            XMM24,
            XMM25,
            XMM26,
            XMM27,
            XMM28,
            XMM29,
            XMM30,
            XMM31,
            YMM0,
            YMM1,
            YMM2,
            YMM3,
            YMM4,
            YMM5,
            YMM6,
            YMM7,
            YMM8,
            YMM9,
            YMM10,
            YMM11,
            YMM12,
            YMM13,
            YMM14,
            YMM15,
            YMM16,
            YMM17,
            YMM18,
            YMM19,
            YMM20,
            YMM21,
            YMM22,
            YMM23,
            YMM24,
            YMM25,
            YMM26,
            YMM27,
            YMM28,
            YMM29,
            YMM30,
            YMM31,
            ZMM0,
            ZMM1,
            ZMM2,
            ZMM3,
            ZMM4,
            ZMM5,
            ZMM6,
            ZMM7,
            ZMM8,
            ZMM9,
            ZMM10,
            ZMM11,
            ZMM12,
            ZMM13,
            ZMM14,
            ZMM15,
            ZMM16,
            ZMM17,
            ZMM18,
            ZMM19,
            ZMM20,
            ZMM21,
            ZMM22,
            ZMM23,
            ZMM24,
            ZMM25,
            ZMM26,
            ZMM27,
            ZMM28,
            ZMM29,
            ZMM30,
            ZMM31,
            LAST,
            BNDCFG_FIRST=BNDCFGU, //< PSEUDO
            BNDCFG_LAST=BNDCFGU, //<PSEUDO
            BNDSTAT_FIRST=BNDSTATUS, //< PSEUDO
            BNDSTAT_LAST=BNDSTATUS, //<PSEUDO
            BOUND_FIRST=BND0, //< PSEUDO
            BOUND_LAST=BND3, //<PSEUDO
            CR_FIRST=CR0, //< PSEUDO
            CR_LAST=CR15, //<PSEUDO
            DR_FIRST=DR0, //< PSEUDO
            DR_LAST=DR7, //<PSEUDO
            FLAGS_FIRST=FLAGS, //< PSEUDO
            FLAGS_LAST=RFLAGS, //<PSEUDO
            GPR16_FIRST=AX, //< PSEUDO
            GPR16_LAST=R15W, //<PSEUDO
            GPR32_FIRST=EAX, //< PSEUDO
            GPR32_LAST=R15D, //<PSEUDO
            GPR64_FIRST=RAX, //< PSEUDO
            GPR64_LAST=R15, //<PSEUDO
            GPR8_FIRST=AL, //< PSEUDO
            GPR8_LAST=R15B, //<PSEUDO
            GPR8h_FIRST=AH, //< PSEUDO
            GPR8h_LAST=BH, //<PSEUDO
            INVALID_FIRST=None, //< PSEUDO
            INVALID_LAST=ERROR, //<PSEUDO
            IP_FIRST=RIP, //< PSEUDO
            IP_LAST=IP, //<PSEUDO
            MASK_FIRST=K0, //< PSEUDO
            MASK_LAST=K7, //<PSEUDO
            MMX_FIRST=MMX0, //< PSEUDO
            MMX_LAST=MMX7, //<PSEUDO
            MSR_FIRST=SSP, //< PSEUDO
            MSR_LAST=IA32_U_CET, //<PSEUDO
            MXCSR_FIRST=MXCSR, //< PSEUDO
            MXCSR_LAST=MXCSR, //<PSEUDO
            PSEUDO_FIRST=STACKPUSH, //< PSEUDO
            PSEUDO_LAST=TILECONFIG, //<PSEUDO
            PSEUDOX87_FIRST=X87CONTROL, //< PSEUDO
            PSEUDOX87_LAST=X87LASTDP, //<PSEUDO
            SR_FIRST=ES, //< PSEUDO
            SR_LAST=GS, //<PSEUDO
            TMP_FIRST=TMP0, //< PSEUDO
            TMP_LAST=TMP15, //<PSEUDO
            TREG_FIRST=TMM0, //< PSEUDO
            TREG_LAST=TMM7, //<PSEUDO
            UIF_FIRST=UIF, //< PSEUDO
            UIF_LAST=UIF, //<PSEUDO
            X87_FIRST=ST0, //< PSEUDO
            X87_LAST=ST7, //<PSEUDO
            XCR_FIRST=XCR0, //< PSEUDO
            XCR_LAST=XCR0, //<PSEUDO
            XMM_FIRST=XMM0, //< PSEUDO
            XMM_LAST=XMM31, //<PSEUDO
            YMM_FIRST=YMM0, //< PSEUDO
            YMM_LAST=YMM31, //<PSEUDO
            ZMM_FIRST=ZMM0, //< PSEUDO
            ZMM_LAST=ZMM31 //<PSEUDO
        }
    }
}