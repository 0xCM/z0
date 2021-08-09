//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    using api = MemorySections;

    partial struct MemorySections
    {
        [StructLayout(LayoutKind.Sequential, Pack=1, Size=(int)StorageSize), Blittable(StorageSize)]
        public readonly struct CapacityIndicator
        {
            public const uint StorageSize = PrimalSizes.U8 + PrimalSizes.U16 + 4*PrimalSizes.U32;

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

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();
        }
    }
}