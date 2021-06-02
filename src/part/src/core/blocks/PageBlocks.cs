//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

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
        public static MemoryCells<T> cells<T>(PageBlock src)
            where T : unmanaged, IDataCell
                => new MemoryCells<T>(src.Range);

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

        [MethodImpl(Inline)]
        public static uint PageCount<T>()
            where T : unmanaged, IPageBlock<T>
                => size<T>()/PageSize;

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