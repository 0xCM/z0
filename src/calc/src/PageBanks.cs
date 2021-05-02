//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static PageBlocks;

    [ApiHost]
    public class PageBanks
    {
        public static PageBanks service()
            => Instance;

        [MethodImpl(Inline), Op]
        public PageBlock Block(N0 n)
            => new PageBlock(BlockIndex[0]);

        [MethodImpl(Inline), Op]
        public PageBlock Block(N1 n)
            => new PageBlock(BlockIndex[1]);

        [MethodImpl(Inline), Op]
        public PageBlock Block(N2 n)
            => new PageBlock(BlockIndex[2]);

        [MethodImpl(Inline), Op]
        public PageBlock Block(N3 n)
            => new PageBlock(BlockIndex[3]);

        public ByteSize BlockSize => _BlockSize;

        internal static void alloc<N,T>(N n, out PageBank<N,T> dst)
            where T : unmanaged, IPageBlock<T>
            where N : unmanaged, ITypeNat
        {
            dst = default;
        }

        Index<MemoryRange> BlockIndex;

        PageBanks()
        {
            BlockIndex = new MemoryRange[4];
            ref var dst = ref BlockIndex.First;
            seek(dst,0) = new MemoryRange(address(Block16x4x0), _BlockSize);
            seek(dst,1) = new MemoryRange(address(Block16x4x1), _BlockSize);
            seek(dst,2) = new MemoryRange(address(Block16x4x2), _BlockSize);
            seek(dst,3) = new MemoryRange(address(Block16x4x3), _BlockSize);
        }

        static PageBanks()
        {
            WinMem.liberate(address(Block16x4x0), size<PageBlock16x4>());
            WinMem.liberate(address(Block16x4x1), size<PageBlock16x4>());
            WinMem.liberate(address(Block16x4x2), size<PageBlock16x4>());
            WinMem.liberate(address(Block16x4x3), size<PageBlock16x4>());
            Instance = new PageBanks();
        }

        static ByteSize _BlockSize => size<PageBlock16x4>();

        static PageBanks Instance;

        [FixedAddressValueType]
        static PageBlock16x4 Block16x4x0;

        [FixedAddressValueType]
        static PageBlock16x4 Block16x4x1;

        [FixedAddressValueType]
        static PageBlock16x4 Block16x4x2;

        [FixedAddressValueType]
        static PageBlock16x4 Block16x4x3;
    }
}