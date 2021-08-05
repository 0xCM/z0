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
    public unsafe readonly partial struct Bss
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static BssDescriptor descriptor(in BssEntry src)
            => new BssDescriptor(src.Id, src.Base(), src.Capacity());

        [MethodImpl(Inline), Op]
        public static bool dispense(ushort id, out BssEntry dst)
        {
            dst = BssData.entry(id);
            if(dst.IsNonEmpty)
            {
                initialize(dst);
                return true;
            }
            else
                return false;
        }

        [Op]
        public static BssEntry dispense(N16 n, N8 scale, W64 w)
            => initialize(BssData.entry(n, scale, w));

        /// <summary>
        /// Specifies a capacity predicated on a cell size, the number of cells in a segment, the block count and a segment scale factor
        /// </summary>
        /// <param name="cellsize">The cell size</param>
        /// <param name="blocks">The number of covered blocks</param>
        /// <param name="blocksegs"></param>
        /// <param name="segcells">The number of cells per segment</param>
        [MethodImpl(Inline), Op]
        public static MemCapacity capacity(ushort cellsize, uint blocks, byte blocksegs, uint segcells)
            => new MemCapacity(cellsize, blocks, blocksegs, segcells);

        [MethodImpl(Inline), Op]
        public static Span<byte> storage(in BssEntry src)
            => cover(src.Base().Pointer<byte>(), src.TotalSize);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> storage<T>(in BssEntry src)
            where T : unmanaged
                => cover(src.Base().Pointer<T>(), src.TotalSize/size<T>());

        [MethodImpl(Inline), Op]
        public static ref byte cell(in BssEntry src, uint index)
        {
            var pBase = src.Base().Pointer<byte>();
            pBase += index;
            return ref @ref<byte>(pBase);
        }

        [MethodImpl(Inline), Op]
        public static Span<byte> segment(in BssEntry src, uint index)
        {
            var pBase = src.Base().Pointer<byte>();
            var unit = src.SegSize;
            var offset = index*unit;
            pBase += offset;
            return cover(pBase, unit);
        }

        [MethodImpl(Inline), Op]
        public static Span<byte> block(in BssEntry src, uint index)
        {
            var pBase = src.Base().Pointer<byte>();
            var unit = src.BlockSize;
            var offset = index*unit;
            pBase += offset;
            return cover(pBase, unit);
        }

        [Op]
        public static string format(in MemCapacity src)
            => string.Format("({0}:{1}x{2}x{3}x{4})", (uint)src.TotalSize, src.CellSize, src.BlockCount, src.BlockSegs, src.SegSize);

        [Op]
        public static string format(in BssDescriptor src)
            => string.Format("{0} {1}{2}", src.Id, src.Range, src.Capacity);

        static ref readonly BssEntry initialize(in BssEntry entry)
        {
            Buffers.liberate(entry.Base(), (ulong)entry.TotalSize);
            return ref entry;
        }
    }
}