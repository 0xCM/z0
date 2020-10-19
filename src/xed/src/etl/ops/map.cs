//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using R = XedInstructionRow;

    partial struct XedWfOps
    {
        [Op]
        public static XedInstructionRow[] instructions(XedPattern[] src)
        {
            var input = @readonly(src);
            var count = input.Length;
            var dst = alloc<R>(count);
            map(src,dst);
            return dst;
        }

        [Op]
        public static void map(ReadOnlySpan<XedPattern> src, Span<XedInstructionRow> dst)
        {
            var count = src.Length;
            ref readonly var input = ref first(src);
            ref var output = ref first(dst);
            for(var i=0u; i<count; i++)
            {
                ref readonly var x = ref skip(input,i);
                seek(output, i) = new R(
                    seq: (int)i,
                    mnemonic: x.Class,
                    ext: x.Extension,
                    @base: x.BaseCodeText(),
                    mod: default,
                    reg: default);
            }
        }
    }
}