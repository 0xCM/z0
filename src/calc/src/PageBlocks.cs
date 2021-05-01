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

    using api = PageBlocks;

    public interface IPageBlock<T>
        where T : unmanaged, IPageBlock<T>
    {
        ByteSize Size
            => size<T>();

        uint PageCount
            => api.PageCount<T>();
    }

    public interface IPageBank<N,T>
        where T : unmanaged, IPageBlock<T>
        where N : unmanaged, ITypeNat
    {
        MemoryAddress BaseAddress {get;}

        uint PageCount
            => api.PageCount<T>();

        ByteSize Size => size<T>();

        MemoryRange Range => (BaseAddress, BaseAddress + Size);
    }

    [ApiHost]
    public class PageBlockProvider
    {
        public static PageBlockProvider service()
            => Instance;

        [MethodImpl(Inline), Op]
        public PageBlock Block(N0 n)
            => new PageBlock(Ranges[0]);

        [MethodImpl(Inline), Op]
        public PageBlock Block(N1 n)
            => new PageBlock(Ranges[1]);

        [MethodImpl(Inline), Op]
        public PageBlock Block(N2 n)
            => new PageBlock(Ranges[2]);

        [MethodImpl(Inline), Op]
        public PageBlock Block(N3 n)
            => new PageBlock(Ranges[3]);

        public ByteSize BlockSize => _BlockSize;

        Index<MemoryRange> Ranges;

        PageBlockProvider()
        {
            Ranges = new MemoryRange[4];
            ref var dst = ref Ranges.First;
            seek(dst,0) = new MemoryRange(address(Block16x4x0), _BlockSize);
            seek(dst,1) = new MemoryRange(address(Block16x4x1), _BlockSize);
            seek(dst,2) = new MemoryRange(address(Block16x4x2), _BlockSize);
            seek(dst,3) = new MemoryRange(address(Block16x4x3), _BlockSize);
        }

        static PageBlockProvider()
        {
            WinMem.liberate(address(Block16x4x0), size<PageBlock16x4>());
            WinMem.liberate(address(Block16x4x1), size<PageBlock16x4>());
            WinMem.liberate(address(Block16x4x2), size<PageBlock16x4>());
            WinMem.liberate(address(Block16x4x3), size<PageBlock16x4>());
            Instance = new PageBlockProvider();
        }

        static ByteSize _BlockSize => size<PageBlock16x4>();

        static PageBlockProvider Instance;

        [FixedAddressValueType]
        static PageBlock16x4 Block16x4x0;

        [FixedAddressValueType]
        static PageBlock16x4 Block16x4x1;

        [FixedAddressValueType]
        static PageBlock16x4 Block16x4x2;

        [FixedAddressValueType]
        static PageBlock16x4 Block16x4x3;
    }

    public struct PageBank<N,T> : IPageBank<N,T>
        where T : unmanaged, IPageBlock<T>
        where N : unmanaged, ITypeNat
    {

        public ByteSize Size => size<T>();

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => address(Storage);
        }

        public MemoryRange Range
        {
            [MethodImpl(Inline)]
            get => (BaseAddress, BaseAddress + Size);
        }

        public uint PageCount
        {
            [MethodImpl(Inline)]
            get => api.PageCount<T>();
        }

        [FixedAddressValueType]
        static T Storage;
    }

    [ApiHost]
    public readonly struct PageBlocks
    {
        /// <summary>
        /// Windows page size = 4096 bytes
        /// </summary>
        public const uint PageSize = Pow2.T12;

        [MethodImpl(Inline), Op]
        public static PageBlockInfo describe(PageBlock src)
            => new PageBlockInfo(src.Range);

        [MethodImpl(Inline)]
        public static CellBuffer<T> cells<T>(PageBlock src)
            where T : unmanaged, IDataCell
                => new CellBuffer<T>(src.Range);

        [MethodImpl(Inline)]
        public static void alloc(out PageBlock16x4 dst)
        {
            dst = default;

        }

        [MethodImpl(Inline)]
        public static void alloc(out PageBlock32x4 dst)
        {
            dst = default;

        }

        [MethodImpl(Inline)]
        public static void alloc(out PageBlock64x4 dst)
        {
            dst = default;
        }

        internal static void bank<N,T>(N n, out PageBank<N,T> dst)
            where T : unmanaged, IPageBlock<T>
            where N : unmanaged, ITypeNat
        {
            dst = default;
        }

        [MethodImpl(Inline)]
        public static uint PageCount<T>()
            where T : unmanaged, IPageBlock<T>
                => size<T>()/PageSize;

        public static uint copy<T>(in CellBuffer<T> src, uint offset, uint cells, Span<T> dst)
            where T : unmanaged, IDataCell
        {
            var j=0u;
            var max = root.min(offset + cells, dst.Length);
            for(var i=offset; i<max; i++)
                seek(dst,j++) = skip(src.View,i);
            return j;
        }

        /// <summary>
        /// Reserves 1 pages of memory that covers 2^12 = 4096 bytes
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        internal struct PageBlock1 : IPageBlock<PageBlock1>
        {
            public const uint Size = PageSize;
        }

        /// <summary>
        /// Reserves 2 pages of memory that cover 2^13 = 8,192 bytes
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        internal struct PageBlock2 : IPageBlock<PageBlock2>
        {
            public const uint Size = Pow2.T13;
        }

        /// <summary>
        /// Reserves 3 pages of memory
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        internal struct PageBlock3 : IPageBlock<PageBlock3>
        {
            public const uint Size = PageBlock2.Size + PageBlock1.Size;
        }

        /// <summary>
        /// Reserves 4 pages of memory that cover 2^14 = 16,384 bytes
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        internal struct PageBlock4 : IPageBlock<PageBlock4>
        {
            public const uint Size = Pow2.T14;
        }

        /// <summary>
        /// Reserves 5 pages of memory
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        internal struct PageBlock5 : IPageBlock<PageBlock5>
        {
            public const uint Size = PageBlock4.Size + PageBlock1.Size;
        }

        /// <summary>
        /// Reserves 6 pages of memory
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        internal struct PageBlock6 : IPageBlock<PageBlock6>
        {
            public const uint Size = PageBlock5.Size + PageBlock1.Size;
        }

        /// <summary>
        /// Reserves 7 pages of memory
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        internal struct PageBlock7 : IPageBlock<PageBlock6>
        {
            public const uint Size = PageBlock6.Size + PageBlock1.Size;
        }

        /// <summary>
        /// Reserves 8 pages of memory that covers 2^15 = 32,768 bytes
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        internal struct PageBlock8 : IPageBlock<PageBlock8>
        {
            public const uint Size = Pow2.T15;
        }

        /// <summary>
        /// Reserves 16 pages of memory that covers 2^16 = 65,536 bytes
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        internal struct PageBlock16 : IPageBlock<PageBlock16>
        {
            public const uint Size = Pow2.T16;
        }

        /// <summary>
        /// Reserves 16 pages of memory that covers 2^17 = 131,072 bytes
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        internal struct PageBlock32 : IPageBlock<PageBlock32>
        {
            public const uint Size = Pow2.T17;
        }

        /// <summary>
        /// Reserves 16 pages of memory that covers 2^18 = 262,144 bytes
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        internal struct PageBlock64 : IPageBlock<PageBlock64>
        {
            public const uint Size = Pow2.T18;
        }

        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        public struct PageBlock16x4 : IPageBlock<PageBlock16x4>
        {
            public const uint BlockSize = PageBlocks.PageBlock16.Size;

            public const uint Size = BlockSize*4;

            PageBlocks.PageBlock16 Block0;

            PageBlocks.PageBlock16 Block1;

            PageBlocks.PageBlock16 Block2;

            PageBlocks.PageBlock16 Block3;
        }


        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        public struct PageBlock32x4 : IPageBlock<PageBlock32x4>
        {
            public const uint BlockSize = PageBlocks.PageBlock32.Size;

            public const uint Size = BlockSize*4;

            PageBlocks.PageBlock32 Block0;

            PageBlocks.PageBlock32 Block1;

            PageBlocks.PageBlock32 Block2;

            PageBlocks.PageBlock32 Block3;
        }

        [StructLayout(LayoutKind.Sequential, Size = (int)Size)]
        public struct PageBlock64x4 : IPageBlock<PageBlock32x4>
        {
            public const uint BlockSize = PageBlocks.PageBlock64.Size;

            public const uint Size = BlockSize*4;

            PageBlocks.PageBlock64 Block0;

            PageBlocks.PageBlock64 Block1;

            PageBlocks.PageBlock64 Block2;

            PageBlocks.PageBlock64 Block3;
        }
    }
}