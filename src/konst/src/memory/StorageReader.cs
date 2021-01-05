//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct StorageReader
    {
        [MethodImpl(Inline), Op]
        public static MemorySegment[] refs(ConstBytes256 src)
             => src.SegRefs();

        [MethodImpl(Inline), Op]
        public static ref readonly byte cell(ConstBytes256 src, byte n, int i)
        {
            if(n == 0)
                return ref cell(src, n0,i);
            else if(n == 1)
                return ref cell(src, n1, i);
            else if(n == 2)
                return ref cell(src, n2, i);
            else if(n == 3)
                return ref cell(src, n3, i);
            else if(n == 4)
                return ref cell(src, n4, i);
            else if(n == 5)
                return ref cell(src, n5, i);
            else if(n == 6)
                return ref cell(src, n6, i);
            else if(n == 7)
                return ref cell(src, n7, i);
            else
                return ref memory.first(src.SegZ);
        }

        [MethodImpl(Inline)]
        public static ref readonly byte cell<N>(ConstBytes256 src, N n, int i) where N : unmanaged, ITypeNat
            => ref memory.skip(span(src, n),(uint)i);

        [MethodImpl(Inline)]
        public static ref readonly byte first<N>(ConstBytes256 src, N n) where N : unmanaged, ITypeNat
            => ref memory.first(span(src, n));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> leads(ConstBytes256 src)
            => src.SegLeads();

        [Op]
        public static ReadOnlySpan<MemoryAddress> locations(ConstBytes256 src, MemorySegments store)
        {
            var sources = store.View;
            var results = sys.alloc<MemoryAddress>(sources.Length);
            Addresses.locations(store,results);
            return results;
        }

        [MethodImpl(Inline), Op]
        public static MemorySegment segment(ConstBytes256 src, byte n)
        {
            if(n == 0)
                return segment(src, n0);
            else if(n == 1)
                return segment(src, n1);
            else if(n == 2)
                return segment(src, n2);
            else if(n == 3)
                return segment(src, n3);
            else if(n == 4)
                return segment(src, n4);
            else if(n == 5)
                return segment(src, n5);
            else if(n == 6)
                return segment(src, n6);
            else if(n == 7)
                return segment(src, n7);
            else
                return segment(src, n256);
        }

        [MethodImpl(Inline)]
        public static unsafe MemorySegment segment<N>(ConstBytes256 src, N n = default)
            where N : unmanaged, ITypeNat
        {
            var buffer = span<N>(src, n);
            var pSrc = gptr(memory.first(buffer));
            return new MemorySegment(pSrc, buffer.Length);
         }

        [MethodImpl(Inline), Op]
        public static MemorySegments segments(ConstBytes256 src)
            => MemorySegments.create(src.SegRefs());

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> span(ConstBytes256 src, byte n)
        {
            if(n == 0)
                return span(src, n0);
            else if(n == 1)
                return span(src, n1);
            else if(n == 2)
                return span(src, n2);
            else if(n == 3)
                return span(src, n3);
            else if(n == 4)
                return span(src, n4);
            else if(n == 5)
                return span(src, n5);
            else if(n == 6)
                return span(src, n6);
            else if(n == 7)
                return span(src, n7);
            else
                return span(src, n256);
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> span<N>(ConstBytes256 src, N n) where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N0))
                return src.Seg(n6, n0);
            else if(typeof(N) == typeof(N1))
                return src.Seg(n6, n1);
            else if(typeof(N) == typeof(N2))
                return src.Seg(n6, n2);
            else if(typeof(N) == typeof(N3))
                return src.Seg(n6, n3);
            else if(typeof(N) == typeof(N4))
                return src.Seg(n7, n0);
            else if(typeof(N) == typeof(N5))
                return src.Seg(n7, n1);
            else if(typeof(N) == typeof(N6))
                return src.Seg(n8, n0);
            else if(typeof(N) == typeof(N7))
                return src.Seg(n8, n0);
            else
                return src.SegZ;
        }
    }
}