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

    partial struct AsmOpCodes
    {
        [Op]
        public AsmOpCodeGroup partition()
        {
            var dataset = AsmOpCodes.dataset();
            var count = dataset.OpCodeCount;
            var handler = new AsmOpCodeGroup((uint)count);
            var p = partitoner();
            p.Partition(dataset.Entries.View, handler);
            return handler;
        }

        [MethodImpl(Inline), Op]
        public static uint partition(ReadOnlySpan<AsmOpCodeRow> src, in AsmOpCodeGroup handler)
        {
            var count = src.Length;
            var s0 = 0u;
            for(var i=s0; i<count; i++)
            {
                ref readonly var row = ref skip(src,i);
                process(row, handler, ref s0);
                s0++;
            }

            return s0;
        }

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
        static void process(in AsmSigExpr src, in AsmOpCodeGroup handler, uint seq)
            => handler.Include(seq, src);

        [MethodImpl(Inline), Op]
        static void process(in AsmOpCodeExpr src, in AsmOpCodeGroup handler, uint seq)
            => handler.Include(seq, src);

        [MethodImpl(Inline), Op]
        static void process(in AsmMnemonicExpr src, in AsmOpCodeGroup handler, uint seq)
            => handler.Include(seq, src);

        [MethodImpl(Inline), Op]
        static void process(in Cpuid src, in AsmOpCodeGroup handler, uint seq)
            => handler.Include(seq, src);
    }
}