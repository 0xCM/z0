//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    using api = MemorySections;

    partial struct MemorySections
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public readonly struct SectionCapacity
        {
            public const uint StorageSize = PrimalSizes.U8 + PrimalSizes.U16 + 6*PrimalSizes.U32;

            /// <summary>
            /// The size of the smallest addressable unit
            /// </summary>
            public ushort CellSize {get;}

            /// <summary>
            /// The number of cells per segment
            /// </summary>
            public uint CellsPerSeg {get;}

            /// <summary>
            /// The number of bytes covered by a segment
            /// </summary>
            public uint SegSize {get;}

            /// <summary>
            /// The number of allocated segments
            /// </summary>
            public uint SegCount {get;}

            /// <summary>
            /// The number of segments per block
            /// </summary>
            public byte SegsPerBlock {get;}

            /// <summary>
            /// The number of blocks covered by the allocation
            /// </summary>
            public uint BlockCount {get;}

            /// <summary>
            /// The size of a block, as determined by <see cref='SegSize'/> * <see cref='SegsPerBlock'/>
            /// </summary>
            public uint BlockSize {get;}

            /// <summary>
            /// The total allocation size, as determined by <see cref='BlockCount'/> * <see cref='BlockSize'/>
            /// </summary>
            public uint TotalSize {get;}

            [MethodImpl(Inline)]
            public SectionCapacity(ushort cellsize, uint blocks, byte blocksegs, uint segcells)
            {
                CellSize = cellsize;
                BlockCount = blocks;
                SegsPerBlock = blocksegs;
                CellsPerSeg = segcells;
                SegSize = segcells*cellsize;
                BlockSize = SegSize*SegsPerBlock;
                TotalSize = BlockCount*BlockSize;
                SegCount = SegSize != 0 ? TotalSize/SegSize : 0;
            }

            public CapacityIndicator Indicator
            {
                [MethodImpl(Inline)]
                get => @as<SectionCapacity,CapacityIndicator>(this);
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => BlockCount == 0;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => TotalSize != 0;
            }

            public string Format()
                => api.format(Indicator);

            public override string ToString()
                => Format();

            public static SectionCapacity Empty => default;
        }
    }
}