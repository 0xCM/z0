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
        public static Index<SymLiteral> records<E>()
            where E : unmanaged, Enum
        {
            var symbols = SymCache<E>.get().View;
            var count = symbols.Length;
            var dst = alloc<SymLiteral>(count);
            records<E>(symbols,dst);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void records<E>(ReadOnlySpan<Sym<E>> src, Span<SymLiteral> dst)
            where E : unmanaged
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                seek(dst,i) = literal(skip(src,i), out _).Untyped();
        }
    }
}