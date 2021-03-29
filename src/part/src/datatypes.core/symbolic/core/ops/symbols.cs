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

    partial struct Symbols
    {
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
                seek(dst,i) = new Sym8<E>((byte)entry.Key, entry.Name, entry.Value, entry.Expression);
            }
            return buffer;
        }

        public static Index<E,Sym16<E>> symbols<E>(W16 w)
            where E : unmanaged, Enum
        {
            var e = Clr.@enum<E>();
            var src = e.SymbolIndex.View;
            var count = src.Length;
            var buffer = alloc<Sym16<E>>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var entry = ref skip(src,i);
                seek(dst,i) = new Sym16<E>((ushort)entry.Key, entry.Name, entry.Value, entry.Expression);
            }
            return buffer;
        }
    }
}