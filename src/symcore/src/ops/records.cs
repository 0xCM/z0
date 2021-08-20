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
        static SymLiteral untype<E>(in SymLiteral<E> src)
            where E : unmanaged
        {
            var dst = new SymLiteral();
            dst.Component = src.Component.SimpleName;
            dst.Type = src.Type;
            dst.Class = src.Class;
            dst.Position = src.Position;
            dst.Name = src.Name;
            dst.Symbol = src.Symbol;
            dst.DataType = src.DataType;
            dst.ScalarValue = src.ScalarValue;
            dst.Description = src.Description;
            dst.Hidden = src.Hidden;
            dst.Identity = src.Identity;
            return dst;
        }

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