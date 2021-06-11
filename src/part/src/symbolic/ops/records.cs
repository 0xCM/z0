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
        public static ReadOnlySpan<SymLiteral> records<E>()
            where E : unmanaged, Enum
        {
            var symbols = index<E>().View;
            var dst = alloc<SymLiteral>(symbols.Length);
            records<E>(symbols, dst);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void records<E>(ReadOnlySpan<Sym<E>> src, Span<SymLiteral> dst)
            where E : unmanaged
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                seek(dst, i) = untype(literal(skip(src,i), out _));
        }
    }
}