//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct Symbols
    {
        const string DefaultPattern = "{0,-8} | {1,-32} | {2}";

        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sym8<T> symbol<T>(W8 w, SymKey<byte> key, Identifier name, T value, SymExpr expr)
            where T : unmanaged
                => new Sym8<T>(key, name,value,expr);

        [MethodImpl(Inline)]
        public static Sym8<E> symbol<E>(W8 w, uint index)
            where E : unmanaged, Enum
        {
            var e = Clr.@enum<E>();
            var entry = e.SymbolIndex[index];
            return symbol(w, (byte)entry.Key, entry.Name, entry.Value, entry.Symbol);
        }

        public static string format(Sym8 src)
            => string.Format(DefaultPattern, src.Key, src.Name, src.Expression);

        public static Index<E,Sym8<E>> symbols<E>(W8 w)
            where E : unmanaged, Enum
        {
            var e = Clr.@enum<E>();
            var src = e.SymbolIndex.View;
            var count = src.Length;
            var buffer = alloc<Sym8<E>>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var entry = ref skip(src,i);
                seek(dst,i) = new Sym8<E>((byte)entry.Key, entry.Name, entry.Value, entry.Symbol);
            }
            return buffer;
        }
    }
}