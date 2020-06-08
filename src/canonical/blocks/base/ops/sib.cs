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
        public ulong sib(in StoreIndex n, int i, byte scale, ushort offset)
            => sib(memref(n),i, scale,offset);

        [MethodImpl(Inline), Op]
        public ulong sib(in MemoryRef n, int i, byte scale, ushort offset)
            => ((ulong)scale)*cell(n.Load(),i) + (ulong)offset;

        [MethodImpl(Inline), Op]
        public ulong sib(in MemoryBlock block, int i, byte scale, ushort offset)
            => ((ulong)scale)*cell(Blocks.load(block), i) + (ulong)offset;
    }
}