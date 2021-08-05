//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    using api = Bss;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public readonly struct BssEntry : IBssEntry<BssEntry>
    {
        readonly BssDescriptor _D;

        [MethodImpl(Inline)]
        internal BssEntry(ushort id, MemoryAddress @base, MemCapacity capacity)
        {
            _D = new BssDescriptor(id, @base, capacity);
        }

        public ushort Id
        {
            [MethodImpl(Inline)]
            get => _D.Id;
        }

        public ByteSize SegSize
        {
            [MethodImpl(Inline)]
            get => _D.SegSize;
        }

        public byte SegScale
        {
            [MethodImpl(Inline)]
            get => _D.SegScale;
        }

        public uint BlockCount
        {
            [MethodImpl(Inline)]
            get => _D.BlockCount;
        }

        public ByteSize BlockSize
        {
            [MethodImpl(Inline)]
            get => _D.BlockSize;
        }

        public ByteSize TotalSize
        {
            [MethodImpl(Inline)]
            get => _D.Capacity.TotalSize;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => _D.IsNonEmpty;
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => TotalSize;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => _D.IsEmpty;
        }

        [MethodImpl(Inline)]
        public MemoryAddress Base()
            => _D.Base;

        [MethodImpl(Inline)]
        public MemCapacity Capacity()
            => _D.Capacity;

        [MethodImpl(Inline)]
        public BssDescriptor Descriptor()
            => api.descriptor(this);

        [MethodImpl(Inline)]
        public Span<byte> Storage()
            => api.storage(this);

        [MethodImpl(Inline)]
        public Span<byte> Segment(uint index)
            => api.segment(this, index);

        [MethodImpl(Inline)]
        public Span<S> Storage<S>()
            where S : unmanaged
                => api.storage<S>(this);

        public string Format()
            => Descriptor().Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BssDescriptor(BssEntry src)
            => src.Descriptor();
    }
}