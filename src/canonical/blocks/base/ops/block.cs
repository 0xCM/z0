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
        public MemoryBlock block(StoreIndex i)
            => block(memref(i));

        [MethodImpl(Inline), Op]
        public MemoryBlock block(in MemoryRef src)
            => Blocks.block(src);

        [MethodImpl(Inline)]
        public MemoryBlock<T> block<T>(in MemoryRef src)
            where T : struct
                => Blocks.block<T>(src);
    }
}