//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public readonly struct FieldIndex
    {
        readonly FieldIndexEntry[] entries;

        [MethodImpl(Inline)]
        public static FieldIndexEntry<E>[] Entries<E>()
            where E : unmanaged, Enum
        {
            var fields = typeof(E).LiteralFields().ToArray();
            var indexed = new FieldIndexEntry<E>[fields.Length];
            for(var i=0; i<indexed.Length; i++)
                indexed[i] = new FieldIndexEntry<E>(i, fields[i].Name,  (E)fields[i].GetRawConstantValue());
            return indexed;
        }

        public static FieldIndex From(FieldIndexEntry[] entries)        
            => new FieldIndex(entries);

        public static FieldIndex<E> From<E>(FieldIndexEntry<E>[] entries)        
            where E : unmanaged, Enum
            => new FieldIndex<E>(entries);

        FieldIndex(FieldIndexEntry[] entries)
        {
            this.entries = entries;
        }

        public ReadOnlySpan<FieldIndexEntry> Fields
        {
            [MethodImpl(Inline)]
            get => entries;
        }
    }    

    public readonly struct FieldIndex<E>
        where E : unmanaged, Enum
    {
        readonly FieldIndexEntry<E>[] entries;        

        internal FieldIndex(FieldIndexEntry<E>[] entries)
        {
            this.entries = entries;
        }

        public ReadOnlySpan<FieldIndexEntry<E>> Fields
        {
            [MethodImpl(Inline)]
            get => entries;
        }
    }    
}