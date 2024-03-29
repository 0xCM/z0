//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    partial struct ConstBytesReader
    {
        [MethodImpl(Inline), Op]
        public static MemorySeg[] refs(ConstBytes256 src)
             => src.SegRefs();

        [MethodImpl(Inline), Op]
        public static ref readonly byte cell(ConstBytes256 src, byte n, int i)
        {
            if(n == 0)
                return ref cell(src, n0, i);
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
                return ref core.first(src.SegZ);
        }

        [MethodImpl(Inline)]
        public static ref readonly byte cell<N>(ConstBytes256 src, N n, int i)
            where N : unmanaged, ITypeNat
                => ref skip(span(src, n),(uint)i);

        [MethodImpl(Inline)]
        public static ref readonly byte first<N>(ConstBytes256 src, N n)
            where N : unmanaged, ITypeNat
                => ref core.first(span(src, n));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> leads(ConstBytes256 src)
            => src.SegLeads();

        [Op]
        public static ReadOnlySpan<MemoryAddress> addresses(ConstBytes256 src, Index<MemorySeg> store)
        {
            var sources = store.View;
            var results = sys.alloc<MemoryAddress>(sources.Length);
            core.addresses(store,results);
            return results;
        }

        [MethodImpl(Inline), Op]
        public static MemorySeg segment(ConstBytes256 src, byte n)
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
        public static unsafe MemorySeg segment<N>(ConstBytes256 src, N n = default)
            where N : unmanaged, ITypeNat
        {
            var buffer = span<N>(src, n);
            var pSrc = gptr(core.first(buffer));
            return new MemorySeg(pSrc, buffer.Length);
         }

        [MethodImpl(Inline), Op]
        public static Index<MemorySeg> segments(ConstBytes256 src)
            => src.SegRefs();

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
        public static ReadOnlySpan<byte> span<N>(ConstBytes256 src, N n)
            where N : unmanaged, ITypeNat
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

        [ApiComplete("storage.reader.cache")]
        public readonly struct Cache
        {
            [MethodImpl(Inline)]
            internal Cache(ConstBytesReader reader)
            {
                Refs = reader.Refs;
                Stores = MemoryStore.Service;
                Reader = reader;
            }

            readonly ConstBytesReader Reader;

            readonly MemorySeg[] Refs;

            readonly MemoryStore Stores;

            [MethodImpl(Inline)]
            public ref readonly byte first_d(N0 n)
                => ref Reader.First(n);

            [MethodImpl(Inline)]
            public ref readonly byte first(N0 n)
                => ref Stores.Cell(Refs, 0,0);

            [MethodImpl(Inline)]
            public ref readonly byte first_d(N1 n)
                => ref Reader.First(n);

            [MethodImpl(Inline)]
            public ref readonly byte first(N1 n)
                => ref Stores.Cell(Refs, 1, 0);

            [MethodImpl(Inline)]
            public ref readonly byte first_d(N2 n)
                => ref Reader.First(n);

            [MethodImpl(Inline)]
            public ref readonly byte first(N2 n)
                => ref Stores.Cell(Refs, 2, 0);

            [MethodImpl(Inline)]
            public ref readonly byte first_d(N3 n)
                => ref Reader.First(n);

            [MethodImpl(Inline)]
            public ref readonly byte first(N3 n)
                => ref Stores.Cell(Refs, 3, 0);

            [MethodImpl(Inline)]
            public ref readonly byte first_d(N4 n)
                => ref Reader.First(n);

            [MethodImpl(Inline)]
            public ref readonly byte first(N4 n)
                => ref Stores.Cell(Refs, 4, 0);

            [MethodImpl(Inline)]
            public ref readonly byte first_d(N5 n)
                => ref Reader.First(n);

            [MethodImpl(Inline)]
            public ref readonly byte first(N5 n)
                => ref Stores.Cell(Refs, 5, 0);

            [MethodImpl(Inline)]
            public ref readonly byte first_d(N6 n)
                => ref Reader.First(n);

            [MethodImpl(Inline)]
            public ref readonly byte first(N6 n)
                => ref Stores.Cell(Refs, 6, 0);

            [MethodImpl(Inline)]
            public ref readonly byte first_d(N7 n)
                => ref Reader.First(n);

            [MethodImpl(Inline)]
            public ref readonly byte first(N7 n)
                => ref Stores.Cell(Refs, 7, 0);

            [MethodImpl(Inline)]
            public ref readonly byte cell_d(N0 n, int i)
                => ref Reader.Cell(n, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell(N0 n, int i)
                => ref Stores.Cell(Refs, 0, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell_d(N1 n, int i)
                => ref Reader.Cell(n, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell(N1 n, int i)
                => ref Stores.Cell(Refs, 1, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell_d(N2 n, int i)
                => ref Reader.Cell(n, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell(N2 n, int i)
                => ref Stores.Cell(Refs, 2, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell_d(N3 n, int i)
                => ref Reader.Cell(n, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell(N3 n, int i)
                => ref Stores.Cell(Refs, 3, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell_d(N4 n, int i)
                => ref Reader.Cell(n, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell(N4 n, int i)
                => ref Stores.Cell(Refs, 4, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell_d(N5 n, int i)
                => ref Reader.Cell(n, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell(N5 n, int i)
                => ref Stores.Cell(Refs, 5, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell_d(N6 n, int i)
                => ref Reader.Cell(n, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell(N6 n, int i)
                => ref Stores.Cell(Refs, 6, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell_d(N7 n, int i)
                => ref Reader.Cell(n, i);

            [MethodImpl(Inline)]
            public ref readonly byte cell(N7 n, int i)
                => ref Stores.Cell(Refs, 7, i);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load_d(N0 n)
                => Reader.Span(n);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load(N0 n)
                => Stores.Load(Refs, 0);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load_d(N1 n)
                => Reader.Span(n);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load(N1 n)
                => Stores.Load(Refs, 1);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load_d(N2 n)
                => Reader.Span(n);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load(N2 n)
                => Stores.Load(Refs, 2);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load_d(N3 n)
                => Reader.Span(n);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load(N3 n)
                => Stores.Load(Refs, 3);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load_d(N4 n)
                => Reader.Span(n);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load(N4 n)
                => Stores.Load(Refs, 4);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load_d(N5 n)
                => Reader.Span(n);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load(N5 n)
                => Stores.Load(Refs, 5);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load_d(N6 n)
                => Reader.Span(n);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load(N6 n)
                => Stores.Load(Refs, 6);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load_d(N7 n)
                => Reader.Span(n);

            [MethodImpl(Inline)]
            public ReadOnlySpan<byte> load(N7 n)
                => Stores.Load(Refs, 7);

            [MethodImpl(Inline)]
            public ref readonly byte cell_d(MemorySlot n, int i)
                => ref Reader.Cell(n,i);

            [MethodImpl(Inline)]
            public ref readonly byte cell(MemorySlot n, int i)
                => ref Stores.Cell(Refs, n,i);

            [MethodImpl(Inline)]
            public ulong sib_d<N>(N n, int i, byte scale, ushort offset)
                where N : unmanaged, ITypeNat
                    => ((ulong)scale)*Reader.Cell(n, i) + (ulong)offset;

            [MethodImpl(Inline)]
            public ulong sib_d(N0 n, int i, byte scale, ushort offset)
                => sib_d<N0>(n, i, scale, offset);

            [MethodImpl(Inline)]
            public ulong sib_d(N1 n, int i, byte scale, ushort offset)
                => sib_d<N1>(n, i, scale, offset);

            [MethodImpl(Inline)]
            public ulong sib_d(MemorySlot n, int i, byte scale, ushort offset)
                => ((ulong)scale)*Reader.Cell(n, i) + (ulong)offset;

            [MethodImpl(Inline)]
            public ulong sib(MemorySlot n, int i, byte scale, ushort offset)
                => Stores.Sib(Refs, n,i,scale,offset);
        }
    }
}