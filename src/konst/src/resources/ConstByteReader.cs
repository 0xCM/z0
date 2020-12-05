//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.ConstBytesReader)]
    public unsafe readonly struct ConstBytesReader
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
        public MemorySegments store()
            => MemorySegments.create(Refs);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> leads()
            => Data.SegLeads();

        [Op]
        public ReadOnlySpan<MemoryAddress> locations(in MemorySegments store)
        {
            var sources = store.View;
            var results = sys.alloc<MemoryAddress>(sources.Length);
            MemRefs.locations(store,results);
            return results;
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> span(byte n)
        {
            if(n == 0)
                return span(n0);
            else if(n == 1)
                return span(n1);
            else if(n == 2)
                return span(n2);
            else if(n == 3)
                return span(n3);
            else if(n == 4)
                return span(n4);
            else if(n == 5)
                return span(n5);
            else if(n == 6)
                return span(n6);
            else if(n == 7)
                return span(n7);
            else
                return span(n256);
        }

        [MethodImpl(Inline), Op]
        public MemorySegment memref(byte n)
        {
            if(n == 0)
                return memref(n0);
            else if(n == 1)
                return memref(n1);
            else if(n == 2)
                return memref(n2);
            else if(n == 3)
                return memref(n3);
            else if(n == 4)
                return memref(n4);
            else if(n == 5)
                return memref(n5);
            else if(n == 6)
                return memref(n6);
            else if(n == 7)
                return memref(n7);
            else
                return memref(n256);
        }

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(byte n, int i)
        {
            if(n == 0)
                return ref cell(n0,i);
            else if(n == 1)
                return ref cell(n1,i);
            else if(n == 2)
                return ref cell(n2,i);
            else if(n == 3)
                return ref cell(n3,i);
            else if(n == 4)
                return ref cell(n4,i);
            else if(n == 5)
                return ref cell(n5,i);
            else if(n == 6)
                return ref cell(n6,i);
            else if(n == 7)
                return ref cell(n7,i);
            else
                return ref z.first(Data.SegZ);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> span<N>(N n)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N0))
                return Data.Seg(n6, n0);
            else if(typeof(N) == typeof(N1))
                return Data.Seg(n6, n1);
            else if(typeof(N) == typeof(N2))
                return Data.Seg(n6, n2);
            else if(typeof(N) == typeof(N3))
                return Data.Seg(n6, n3);
            else if(typeof(N) == typeof(N4))
                return Data.Seg(n7, n0);
            else if(typeof(N) == typeof(N5))
                return Data.Seg(n7, n1);
            else if(typeof(N) == typeof(N6))
                return Data.Seg(n8, n0);
            else if(typeof(N) == typeof(N7))
                return Data.Seg(n8, n0);
            else
                return Data.SegZ;
        }

        [MethodImpl(Inline)]
        public ref readonly byte first<N>(N n)
            where N : unmanaged, ITypeNat
                => ref z.first(span(n));

        [MethodImpl(Inline)]
        public ref readonly byte cell<N>(N n, int i)
            where N : unmanaged, ITypeNat
                => ref skip(span(n),(uint)i);

        [MethodImpl(Inline)]
        public unsafe MemorySegment memref<N>(N n = default)
            where N : unmanaged, ITypeNat
        {
            var src = span<N>(n);
            var pSrc = gptr(z.first(src));
            return new MemorySegment(pSrc, src.Length);
        }
    }
}