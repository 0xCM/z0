//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        partial struct Factory
        {
            [MethodImpl(Inline),Op, Closures(Closure)]
            public static uint expr<T>(in Symbols<T> src, Span<text7> dst)
                where T : unmanaged
            {
                var count = (uint)min(src.Length, dst.Length);
                var symbols = src.View;
                for(var i=0; i<count; i++)
                {
                    ref readonly var symbol = ref skip(symbols,i);
                    var data = symbol.Expr.Data;
                    seek(dst, i) = text(n7, data);
                }
                return count;
            }
        }
    }
}