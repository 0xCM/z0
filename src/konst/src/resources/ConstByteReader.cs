//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = StorageReader;

    //[ApiHost(ApiNames.ConstBytesReader)]
    public unsafe readonly struct ConstBytesReader : IStorageReader<ConstBytesReader, ConstBytes256>
    {
        readonly ConstBytes256 Data;

        [MethodImpl(Inline)]
        internal ConstBytesReader(ConstBytes256 data)
            => Data = data;

        public MemorySegment[] Refs
        {
            [MethodImpl(Inline)]
            get => Data.SegRefs();
        }

        [MethodImpl(Inline), Op]
        public MemorySegments Segments()
            => api.segments(Data);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> Leads()
            => api.leads(Data);

        [Op]
        public ReadOnlySpan<MemoryAddress> Locations(MemorySegments store)
            => api.locations(Data, store);

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Span(byte n)
            => api.span(Data, n);

        [MethodImpl(Inline)]
        public MemorySegment Segment(byte n)
            => api.segment(Data, n);

        [MethodImpl(Inline)]
        public ref readonly byte Cell(byte n, int i)
            => ref api.cell(Data, n, i);

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Span<N>(N n)
            where N : unmanaged, ITypeNat
            => api.span(Data, n);

        [MethodImpl(Inline)]
        public ref readonly byte First<N>(N n)
            where N : unmanaged, ITypeNat
                => ref api.first(Data, n);

        [MethodImpl(Inline)]
        public ref readonly byte Cell<N>(N n, int i)
            where N : unmanaged, ITypeNat
                => ref api.cell(Data, n, i);

        [MethodImpl(Inline)]
        public unsafe MemorySegment Segment<N>(N n = default)
            where N : unmanaged, ITypeNat
                => api.segment(Data, n);
    }
}