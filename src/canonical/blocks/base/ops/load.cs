//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    partial struct MemoryStore
    {
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(StoreIndex n)
            => load(memref(n));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(in MemoryRef src)
            => src.Load();

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> load<T>(in MemoryRef src)
            where T : struct
                => src.Load<T>();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(in MemoryBlock src)
            => Blocks.load(src);
    }
}