//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IStorageReader<H,T>
        where T : unmanaged
        where H : struct, IStorageReader<H,T>
    {
        MemorySegment[] Refs {get;}

        MemorySegments Segments();

        ReadOnlySpan<byte> Span(byte n);

        MemorySegment Segment(byte n);

        ReadOnlySpan<byte> Leads();

        ReadOnlySpan<MemoryAddress> Locations(MemorySegments store);

        ref readonly byte Cell(byte n, int i);

        ReadOnlySpan<byte> Span<N>(N n)
            where N : unmanaged, ITypeNat;

        ref readonly byte First<N>(N n)
            where N : unmanaged, ITypeNat;

        ref readonly byte Cell<N>(N n, int i)
            where N : unmanaged, ITypeNat;

        MemorySegment Segment<N>(N n = default)
            where N : unmanaged, ITypeNat;
    }

}