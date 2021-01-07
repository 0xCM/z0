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
                //partition(skip(src,i), handler, ref s0);
            }

            return s0;
        }

        // [MethodImpl(Inline), Op]
        // static void partition(in AsmOpCodeRow src, in AsmOpCodeGroup handler, ref uint s0)
        // {
        //     process(src, handler, ref s0);
        //     s0++;
        // }
    }
}