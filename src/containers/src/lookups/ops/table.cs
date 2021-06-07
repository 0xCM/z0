//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Lookups
    {
        internal static LookupTable<K,T> table<K,T>(MemoryAddress @base, uint[] offsets, uint[] lengths)
            where K : unmanaged
                => new LookupTable<K,T>(@base, offsets, lengths);

        public static LookupTable<K,T> table<K,T>(MemoryAddress @base, uint count)
            where K : unmanaged
                => new LookupTable<K,T>(@base, sys.alloc<uint>(count), sys.alloc<uint>(count));
    }
}