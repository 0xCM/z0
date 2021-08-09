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

    using api = MemorySections;

    partial struct MemorySections
    {
        [StructLayout(LayoutKind.Sequential, Pack=1, Size=(int)StorageSize), Blittable(StorageSize)]
        public readonly struct SectionEntry : ISectionEntry<SectionEntry>
        {
            public const uint StorageSize = SectionDescriptor.StorageSize;

            readonly SectionDescriptor _D;

            [MethodImpl(Inline)]
            internal SectionEntry(ushort id, MemoryAddress @base, SectionCapacity capacity)
            {
                _D = new SectionDescriptor(id, @base, capacity);
            }

            public ushort Index
            {
                [MethodImpl(Inline)]
                get => _D.Index;
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
                => _D.BaseAddress;

            [MethodImpl(Inline)]
            public SectionCapacity Capacity()
                => _D.Capacity;

            [MethodImpl(Inline)]
            public SectionDescriptor Descriptor()
                => api.descriptor(this);

            [MethodImpl(Inline)]
            public Span<byte> Storage()
                => api.cells(this);

            [MethodImpl(Inline)]
            public Span<byte> Segment(uint index)
                => api.segment(this, index);

            [MethodImpl(Inline)]
            public Span<S> Storage<S>()
                where S : unmanaged
                    => api.cells<S>(this);

            public string Format()
                => Descriptor().Format();

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator SectionDescriptor(SectionEntry src)
                => src.Descriptor();
        }
    }
}