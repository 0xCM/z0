//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using F = AsmOpCodeField;

    partial struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        static void process(in AsmOpCodeRow src, in AsmOpCodeGroup handler, ref uint s0)
        {
            process(opcode(src), handler, s0);
            process(sig(src), handler, s0);
            process(mnemonic(src), handler, s0);
            process(cpuid(src), handler, s0);
        }

       [MethodImpl(Inline), Op]
        static void process(OperatingMode src, in AsmOpCodeGroup handler, ref uint seq)
            => handler.Include(seq, src);

        [MethodImpl(Inline), Op]
        static void process(in AsmSig src, in AsmOpCodeGroup handler, uint seq)
            => handler.Include(seq, src);

        [MethodImpl(Inline), Op]
        static void process(in AsmOpCodeExpression src, in AsmOpCodeGroup handler, uint seq)
            => handler.Include(seq, src);

        [MethodImpl(Inline), Op]
        static void process(in MnemonicExpression src, in AsmOpCodeGroup handler, uint seq)
            => handler.Include(seq, src);

        [MethodImpl(Inline), Op]
        static void process(in CpuidExpression src, in AsmOpCodeGroup handler, uint seq)
            => handler.Include(seq, src);
    }
}