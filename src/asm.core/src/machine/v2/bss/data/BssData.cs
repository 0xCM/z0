//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    readonly partial struct BssData
    {
        [Op]
        public static Bss1x16x8x64 data(W8 cellsize, N16 blocks, N8 segblocks, N64 segcells)
            => default(Bss1x16x8x64);

        public static BssEntry entry(ushort id)
        {
            var e = default(BssEntry);
            switch(id)
            {
                case 0:
                    e = entry(default(Bss1x16x8x64));
                break;
            }
            return e;
        }

        public static BssEntry entry(N16 n, N8 scale, W64 w)
            => entry(default(Bss1x16x8x64));

        [MethodImpl(Inline), Op]
        static MemCapacity capacity(ushort segsize, uint n, byte blocksegs, uint segcells)
            => new MemCapacity(segsize, n, blocksegs, segcells);

        [MethodImpl(Inline)]
        static BssEntry<T> entry<T>(in T src)
            where T : unmanaged, IBss<T>
                => new BssEntry<T>(src.Id,src.Base(), src.Capacity());
    }
}