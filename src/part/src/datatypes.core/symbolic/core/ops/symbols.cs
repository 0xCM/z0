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
            var entries = SymCache<E>.get().Entries.View;
            var count = entries.Length;
            var buffer = alloc<Sym8<E>>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var entry = ref skip(entries,i);
                seek(dst,i) = symbol(w8, entry.Identity, (byte)entry.Index, entry.Name, entry.Value, entry.Expression);
            }
            return buffer;
        }

        public static Index<E,Sym16<E>> symbols<E>(W16 w)
            where E : unmanaged, Enum
        {
            var entries = SymCache<E>.get().Entries.View;
            var count = entries.Length;
            var buffer = alloc<Sym16<E>>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var entry = ref skip(entries,i);
                seek(dst,i) = symbol(w16, entry.Identity, (ushort)entry.Index, entry.Name, entry.Value, entry.Expression);
            }
            return buffer;
        }
    }
}