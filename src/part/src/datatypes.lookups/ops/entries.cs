//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    partial struct Lookups
    {
        /// <summary>
        /// Creates a lookup table
        /// </summary>
        /// <param name="src">The table entries</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static LookupEntries<K,V> entries<K,V>(LookupEntry<K,V>[] src)
            where K : unmanaged
                => new LookupEntries<K,V>(src);

        public static SymbolEntries<E> entries<E>()
            where E : unmanaged, Enum
        {
            var literals = ClrPrimitives.enums<E>();
            var view = literals.View;
            var count = view.Length;
            var entries = memory.alloc<SymbolEntry<E>>(count);
            ref var entry = ref memory.first(entries);
            var index = new Dictionary<string,SymbolEntry<E>>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var literal = ref skip(view, i);
                seek(entry, i) = entry<E>(i, literal);
                index.Add(literal.Name, skip(entry, i));
            }
            return new SymbolEntries<E>(entries, index);
        }

        [MethodImpl(Inline)]
        static SymbolEntry<E> entry<E>(uint index, SymbolicLiteral<E> src)
            where E : unmanaged, Enum
                => new SymbolEntry<E>(index, src.Name, src);
    }
}