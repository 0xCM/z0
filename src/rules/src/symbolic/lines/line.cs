//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;

    partial struct Lines
    {
        [Op]
        public static uint line(ReadOnlySpan<AsciCode> src, ref uint counter, ref uint pos, out AsciLine dst)
        {
            var i0 = pos;
            dst = default;
            var size = src.Length;
            while(pos++ < size - 1)
            {
                ref readonly var a0 = ref skip(src, pos);
                ref readonly var a1 = ref skip(src, pos + 1);
                if(SQ.eol(a0,a1))
                    dst = new AsciLine(++counter, i0, slice(src,i0, pos));
            }

            return pos-i0;
        }
    }
}