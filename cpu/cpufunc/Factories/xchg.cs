//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static MnemonicKind;
    using static AsmSymTypes;
    using static zfunc;

    partial class asm
    {

        [AsmInstr(XCHG, "90+rw", "XCHG AX, r16")]
        public static void xchg(AX ax, Reg16 r16)
            => expr(XCHG, ax, r16);

        [AsmInstr(XCHG, "90+rw", "XCHG r16, AX")]
        public static void xchg(Reg16 r16, AX ax)
            => expr(XCHG, r16, ax);

        [AsmInstr(XCHG, "90+rd", "XCHG EAX, r32")]
        public static void xchg(EAX eax, Reg32 r32)
            => expr(XCHG, eax, r32);

        [AsmInstr(XCHG, "REX.W + 90+rd", "XCHG RAX, r64")]
        public static void xchg(RAX rax, Reg64 r64)
            => expr(XCHG, rax, r64);


    }

}