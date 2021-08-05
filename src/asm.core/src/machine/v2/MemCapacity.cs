//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    using api = Bss;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public readonly struct MemCapacity
    {
        /// <summary>
        /// The size of the smallest addressable unit
        /// </summary>
        public ushort CellSize {get;}

        /// <summary>
        /// The number of cells per segment
        /// </summary>
        public uint SegCells {get;}

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
        public byte BlockSegs {get;}

        /// <summary>
        /// The number of blocks covered by the allocation
        /// </summary>
        public uint BlockCount {get;}

        /// <summary>
        /// The size of a block, as determined by <see cref='SegSize'/> * <see cref='BlockSegs'/>
        /// </summary>
        public uint BlockSize {get;}

        /// <summary>
        /// The total allocation size, as determined by <see cref='BlockCount'/> * <see cref='BlockSize'/>
        /// </summary>
        public uint TotalSize {get;}

        [MethodImpl(Inline)]
        public MemCapacity(ushort cellsize, uint blocks, byte blocksegs, uint segcells)
        {
            CellSize = cellsize;
            BlockCount = blocks;
            BlockSegs = blocksegs;
            SegCells = segcells;
            SegSize = segcells*cellsize;
            BlockSize = SegSize*BlockSegs;
            TotalSize = BlockCount*BlockSize;
            SegCount = SegSize != 0 ? TotalSize/SegSize : 0;
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
            => api.format(this);

        public override string ToString()
            => Format();

        public static MemCapacity Empty => default;
    }
}