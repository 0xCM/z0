//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Windows;


    using static Part;
    using static memory;
    using static ProcessMemory;

    [ApiHost]
    public readonly struct MemoryRegionTraversers
    {
        [Op, MethodImpl(Inline)]
        public static MemoryRegionTraverser create(ReadOnlySpan<MemoryRegion> src, bool live)
            => new MemoryRegionTraverser(src, live);

        # if NET5_0_OR_GREATER
        [Op, MethodImpl(Inline)]
        public static unsafe ByteSize run(RegionTraverser traverser, delegate* unmanaged<in MemoryRegion,void> dst)
            => traverser.Traverse(dst);
        # endif

        [Op]
        public static unsafe Index<MemoryRegion> filter(ReadOnlySpan<MemoryRegion> src, PageProtection protect)
        {
            var dst  = alloc<MemoryRegion>((uint)src.Length);
            var traverser = create(src,false);
            var filter = new MemoryRegionFilter(dst,protect);
            var size = traverser.Traverse(filter);
            return filter.Emit();
        }

        unsafe struct MemoryRegionFilter : IReceiver<MemoryRegion>
        {
            readonly Index<MemoryRegion> Accepted;

            readonly PageProtection Protection;

            uint Position;

            [MethodImpl(Inline)]
            public MemoryRegionFilter(Index<MemoryRegion> dst, PageProtection protection)
            {
                Accepted = dst;
                Protection = protection;
                Position = 0;
            }

            [MethodImpl(Inline)]
            public void Deposit(in MemoryRegion src)
            {
                if((src.Protection & Protection) != 0)
                {
                    Accepted[Position++] = src;
                }
            }

            public Index<MemoryRegion> Emit()
                => Accepted;
        }
    }
}