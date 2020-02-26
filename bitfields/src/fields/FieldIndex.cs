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
    using System.Reflection;

    using static zfunc;

    public readonly struct FieldIndex : IFieldIndex<FieldIndexEntry>
    {
        readonly FieldIndexEntry[] entries;

        public static FieldIndex<I,W> Create<I,U,W>()
            where I : unmanaged, Enum
            where U : unmanaged
            where W : unmanaged, Enum
        {
            var indices = typeof(I).LiteralFields().ToArray();
            var widths = typeof(W).LiteralFields().ToArray();
            var count = indices.Length;
            var indexed = new FieldIndexEntry<I,W>[count];
            for(var i=0; i < count; i++)
                indexed[i] = CreateEntry<I,U,W>(i, indices, widths);
            return indexed;
        }

        [MethodImpl(Inline)]
        static FieldIndexEntry<I,W> CreateEntry<I,U,W>(int i, FieldInfo[] indices, FieldInfo[] widths)
            where U : unmanaged
            where I : unmanaged, Enum
            where W : unmanaged, Enum
                => new FieldIndexEntry<I,W>(
                    index: Enums.literal<U,I>(convert<int,U>(i)), 
                    name: indices[i].Name,  
                    width: (W)widths[i].GetRawConstantValue()
                    );

        public static FieldIndex From(FieldIndexEntry[] entries)        
            => new FieldIndex(entries);

        FieldIndex(FieldIndexEntry[] entries)
        {
            this.entries = entries;
        }

        public ReadOnlySpan<FieldIndexEntry> Entries
        {
            [MethodImpl(Inline)]
            get => entries;
        }
    }    
}