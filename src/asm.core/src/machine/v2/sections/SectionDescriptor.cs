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
        [StructLayout(LayoutKind.Sequential, Pack=1, Size=(int)SZ), Blittable(SZ)]
        public readonly struct SectionDescriptor
        {
            public const uint SZ = Hex16.StorageSize + MemoryAddress.SZ + SectionCapacity.StorageSize;

            /// <summary>
            /// A 0-based surrogate key
            /// </summary>
            public Hex16 Index {get;}

            /// <summary>
            /// The first address covered by the section
            /// </summary>
            public MemoryAddress BaseAddress {get;}

            /// <summary>
            /// The capacity specifier
            /// </summary>
            public SectionCapacity Capacity {get;}

            [MethodImpl(Inline)]
            public SectionDescriptor(ushort id, MemoryAddress @base, SectionCapacity capacity)
            {
                Index = id;
                BaseAddress = @base;
                Capacity = capacity;
            }

            /// <summary>
            /// The number of blocks covered by the allocation
            /// </summary>
            public uint BlockCount
            {
                [MethodImpl(Inline)]
                get => Capacity.BlockCount;
            }

            /// <summary>
            /// The factor by which to scale the segment to determine the block size
            /// </summary>
            public byte SegScale
            {
                [MethodImpl(Inline)]
                get => Capacity.SegsPerBlock;
            }

            /// <summary>
            /// The number of bytes covered by a segment
            /// </summary>
            public ByteSize SegSize
            {
                [MethodImpl(Inline)]
                get => Capacity.SegSize;
            }

            /// <summary>
            /// The size of a block, as determined by <see cref='SegSize'/> * <see cref='SegScale'/>
            /// </summary>
            public ByteSize BlockSize
            {
                [MethodImpl(Inline)]
                get => Capacity.BlockSize;
            }

            public ByteSize TotalSize
            {
                [MethodImpl(Inline)]
                get => Capacity.TotalSize;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Capacity.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Capacity.IsNonEmpty;
            }

            public MemoryRange AddressRange
            {
                [MethodImpl(Inline)]
                get => new MemoryRange(BaseAddress, TotalSize);
            }

            /// <summary>
            /// The last address covered by the section
            /// </summary>
            public MemoryAddress EndAddress
            {
                [MethodImpl(Inline)]
                get => BaseAddress + TotalSize;
            }

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();
        }
    }
}