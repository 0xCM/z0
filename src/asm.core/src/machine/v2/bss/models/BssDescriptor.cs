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
    public readonly struct BssDescriptor
    {
        /// <summary>
        /// The bss index, relative to other bss allocations
        /// </summary>
        public Hex16 Id {get;}

        /// <summary>
        /// The bss base address
        /// </summary>
        public MemoryAddress Base {get;}

        /// <summary>
        /// The capacity specifier
        /// </summary>
        public MemCapacity Capacity {get;}

        [MethodImpl(Inline)]
        public BssDescriptor(ushort id, MemoryAddress @base, MemCapacity capacity)
        {
            Id = id;
            Base = @base;
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
            get => Capacity.BlockSegs;
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

        public MemoryRange Range
        {
            [MethodImpl(Inline)]
            get => new MemoryRange(Base, TotalSize);
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}