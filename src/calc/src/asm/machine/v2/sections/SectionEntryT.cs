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
        [StructLayout(LayoutKind.Sequential, Pack=1, Size=(int)SZ), Blittable(SZ)]
        public readonly struct SectionEntry<T> : ISectionEntry<SectionEntry<T>>
            where T : unmanaged, IMemorySection<T>
        {
            public const uint SZ = SectionDescriptor.SZ;

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
            public Span<S> Storage<S>()
                where S : unmanaged
                    => api.cells<S>(this);

            public string Format()
                => Descriptor().Format();

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator SectionEntry(SectionEntry<T> src)
                => new SectionEntry(src.Index, src.Base(), src.Capacity());

            [MethodImpl(Inline)]
            public static implicit operator SectionDescriptor(SectionEntry<T> src)
                => src.Descriptor();
        }
    }
}