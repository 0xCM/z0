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

    partial struct Symbols
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void kinds<T>(Symbols<T> src, Span<T> dst)
            where T : unmanaged
        {
            var count = min(src.Length,dst.Length);
            var view = src.Kinds;
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(view,i);
        }
    }
}