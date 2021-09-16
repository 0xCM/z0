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
    public unsafe readonly partial struct MemorySections
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static SectionDescriptor descriptor(in SectionEntry src)
            => new SectionDescriptor(src.Index, src.Base(), src.Capacity());

        [MethodImpl(Inline)]
        public static SectionEntry<T> entry<T>(in T src)
            where T : unmanaged, IMemorySection<T>
                => new SectionEntry<T>(src.Index, src.Base(), src.Capacity());

        [MethodImpl(Inline)]
        public static bool dispense<T>(T src, ushort id, out SectionEntry dst)
            where T : ISectionDispenser<T>
        {
            dst = src.Entry(id);
            return dst.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public static uint dispense<T>(T src, out ReadOnlySpan<SectionEntry> dst)
            where T : ISectionDispenser<T>
        {
            dst = src.Entries();
            return src.EntryCount;
        }

        [Op]
        public static ref readonly SectionEntry initialize(in SectionEntry entry)
        {
            Buffers.liberate(entry.Base(), (ulong)entry.TotalSize);
            return ref entry;
        }

        /// <summary>
        /// Specifies a capacity predicated on a cell size, the number of cells in a segment, the block count and a segment scale factor
        /// </summary>
        /// <param name="cellsize">The cell size</param>
        /// <param name="blocks">The number of covered blocks</param>
        /// <param name="blocksegs"></param>
        /// <param name="segcells">The number of cells per segment</param>
        [MethodImpl(Inline), Op]
        public static SectionCapacity capacity(ushort cellsize, uint blocks, byte blocksegs, uint segcells)
            => new SectionCapacity(cellsize, blocks, blocksegs, segcells);

        [MethodImpl(Inline), Op]
        public static Span<byte> cells(in SectionEntry src)
            => cover(src.Base().Pointer<byte>(), src.TotalSize);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cells<T>(in SectionEntry src)
            where T : unmanaged
                => cover(src.Base().Pointer<T>(), src.TotalSize/size<T>());

        [MethodImpl(Inline), Op]
        public static ref byte cell(in SectionEntry src, uint index)
        {
            var pBase = src.Base().Pointer<byte>();
            pBase += index;
            return ref @ref<byte>(pBase);
        }

        [MethodImpl(Inline), Op]
        public static Span<byte> segment(in SectionEntry src, uint index)
        {
            var pBase = src.Base().Pointer<byte>();
            var unit = src.SegSize;
            var offset = index*unit;
            pBase += offset;
            return cover(pBase, unit);
        }

        [MethodImpl(Inline), Op]
        public static Span<byte> block(in SectionEntry src, uint index)
        {
            var pBase = src.Base().Pointer<byte>();
            var unit = src.BlockSize;
            var offset = index*unit;
            pBase += offset;
            return cover(pBase, unit);
        }

        /// <summary>
        /// {CellSize}x{SegSize}x{SegsPerBlock}x{BlockCount}
        /// </summary>
        /// <param name="src"></param>
        [Op]
        public static string format(in CapacityIndicator src)
            => string.Format("{0}x{1}x{2}x{3}", src.CellSize, src.SegSize, src.SegsPerBlock, src.BlockCount);

        [Op]
        public static string format(in SectionDescriptor src)
            => string.Format("{0} {1}{2}", src.Index, src.AddressRange, src.Capacity);
    }
}