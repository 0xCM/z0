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
    using static ProcessMemory;

    public readonly ref struct MemoryRegionTraverser
    {
        readonly ReadOnlySpan<MemoryRegion> Regions;

        readonly bool IsLive;

        [MethodImpl(Inline)]
        public MemoryRegionTraverser(ReadOnlySpan<MemoryRegion> src, bool live)
        {
            Regions = src;
            IsLive = live;
        }

        [MethodImpl(Inline), Op]
        public ByteSize Traverse(IReceiver<MemoryRegion> dst)
        {
            var size = ByteSize.Zero;
            var src = Regions;
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var region = ref skip(src,i);
                dst.Deposit(region);
                size += region.Size;
            }
            return size;
        }

        [MethodImpl(Inline), Op]
        public unsafe ByteSize Traverse(delegate* unmanaged<in MemoryRegion,void> dst)
        {
            var size = ByteSize.Zero;
            var src = Regions;
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var region = ref skip(src,i);
                dst(region);
                size += region.Size;
            }
            return size;
        }
    }
}