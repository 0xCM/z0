//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-reg-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        [SymbolSource(xed)]
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

            [AsmPseudoReg]
            BNDCFG_FIRST=BNDCFGU,

            [AsmPseudoReg]
            BNDCFG_LAST=BNDCFGU,

            [AsmPseudoReg]
            BNDSTAT_FIRST=BNDSTATUS,

            [AsmPseudoReg]
            BNDSTAT_LAST=BNDSTATUS,

            [AsmPseudoReg]
            BOUND_FIRST=BND0,

            [AsmPseudoReg]
            BOUND_LAST=BND3,

            [AsmPseudoReg]
            CR_FIRST=CR0,

            [AsmPseudoReg]
            CR_LAST=CR15,

            [AsmPseudoReg]
            DR_FIRST=DR0,

            [AsmPseudoReg]
            DR_LAST=DR7,

            [AsmPseudoReg]
            FLAGS_FIRST=FLAGS,

            [AsmPseudoReg]
            FLAGS_LAST=RFLAGS,

            [AsmPseudoReg]
            GPR16_FIRST=AX,

            [AsmPseudoReg]
            GPR16_LAST=R15W,

            [AsmPseudoReg]
            GPR32_FIRST=EAX,

            [AsmPseudoReg]
            GPR32_LAST=R15D,

            [AsmPseudoReg]
            GPR64_FIRST=RAX,

            [AsmPseudoReg]
            GPR64_LAST=R15,

            [AsmPseudoReg]
            GPR8_FIRST=AL,

            [AsmPseudoReg]
            GPR8_LAST=R15B,

            [AsmPseudoReg]
            GPR8h_FIRST=AH,

            [AsmPseudoReg]
            GPR8h_LAST=BH,

            [AsmPseudoReg]
            INVALID_FIRST=None,

            [AsmPseudoReg]
            INVALID_LAST=ERROR,

            [AsmPseudoReg]
            IP_FIRST=RIP,

            [AsmPseudoReg]
            IP_LAST=IP,

            [AsmPseudoReg]
            MASK_FIRST=K0,

            [AsmPseudoReg]
            MASK_LAST=K7,

            [AsmPseudoReg]
            MMX_FIRST=MMX0,

            [AsmPseudoReg]
            MMX_LAST=MMX7,

            [AsmPseudoReg]
            MSR_FIRST=SSP,

            [AsmPseudoReg]
            MSR_LAST=IA32_U_CET,

            [AsmPseudoReg]
            MXCSR_FIRST=MXCSR,

            [AsmPseudoReg]
            MXCSR_LAST=MXCSR,

            [AsmPseudoReg]
            PSEUDO_FIRST=STACKPUSH,

            [AsmPseudoReg]
            PSEUDO_LAST=TILECONFIG,

            [AsmPseudoReg]
            PSEUDOX87_FIRST=X87CONTROL,

            [AsmPseudoReg]
            PSEUDOX87_LAST=X87LASTDP,

            [AsmPseudoReg]
            SR_FIRST=ES,

            [AsmPseudoReg]
            SR_LAST=GS,

            [AsmPseudoReg]
            TMP_FIRST=TMP0,

            [AsmPseudoReg]
            TMP_LAST=TMP15,

            [AsmPseudoReg]
            TREG_FIRST=TMM0,

            [AsmPseudoReg]
            TREG_LAST=TMM7,

            [AsmPseudoReg]
            UIF_FIRST=UIF,

            [AsmPseudoReg]
            UIF_LAST=UIF,

            [AsmPseudoReg]
            X87_FIRST=ST0,

            [AsmPseudoReg]
            X87_LAST=ST7,

            [AsmPseudoReg]
            XCR_FIRST=XCR0,

            [AsmPseudoReg]
            XCR_LAST=XCR0,

            [AsmPseudoReg]
            XMM_FIRST=XMM0,

            [AsmPseudoReg]
            XMM_LAST=XMM31,

            [AsmPseudoReg]
            YMM_FIRST=YMM0,

            [AsmPseudoReg]
            YMM_LAST=YMM31,

            [AsmPseudoReg]
            ZMM_FIRST=ZMM0,

            [AsmPseudoReg]
            ZMM_LAST=ZMM31
        }
    }
}