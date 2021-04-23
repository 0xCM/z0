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

    public readonly struct MethodTable<K>
        where K : unmanaged
    {
        public Identifier Name {get;}

        readonly Index<MethodEntryPoint<K>> EntryPoints;

        readonly Index<K,uint> EntryIndex;

        [MethodImpl(Inline)]
        public MethodTable(Identifier name, Index<MethodEntryPoint<K>> entries, Index<K,uint> index)
        {
            Name = name;
            EntryPoints = entries;
            EntryIndex = index;
        }

        public ref readonly MethodEntryPoint<K> this[K key]
        {
            [MethodImpl(Inline)]
            get => ref EntryPoints[EntryIndex[key]];
        }

    }
}