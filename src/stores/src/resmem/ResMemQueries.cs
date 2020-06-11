//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    [ApiHost]
    readonly struct ResMemQueries : IApiHost<ResMemQueries>
    {        
        [MethodImpl(Inline)]
        internal ResMemQueries(ResMemServices src)
        {
            Direct = src;
            Refs = ResMemStore.Data.provided();
            Storage = MemStore.Service(Refs);
            api = MemStores.Service;
        }        
                
        readonly MemoryRef[] Refs;                
        
        readonly ResMemServices Direct;

        readonly MemStore Storage;

        readonly MemStores api;


        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N0 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N0 n)
            => ref api.cell(Refs, 0,0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N1 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N1 n)
            => ref api.cell(Refs, 1, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N2 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N2 n)
            => ref api.cell(Refs, 2, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N3 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N3 n)
            => ref api.cell(Refs, 3, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N4 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N4 n)
            => ref api.cell(Refs, 4, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N5 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N5 n)
            => ref api.cell(Refs, 5, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N6 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N6 n)
            => ref api.cell(Refs, 6, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N7 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N7 n)
            => ref api.cell(Refs, 7, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N0 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N0 n, int i)
            => ref api.cell(Refs, 0, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N1 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N1 n, int i)
            => ref api.cell(Refs, 1, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N2 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N2 n, int i)
            => ref api.cell(Refs, 2, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N3 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N3 n, int i)
            => ref api.cell(Refs, 3, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N4 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N4 n, int i)
            => ref api.cell(Refs, 4, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N5 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N5 n, int i)
            => ref api.cell(Refs, 5, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N6 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N6 n, int i)
            => ref api.cell(Refs, 6, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N7 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N7 n, int i)
            => ref api.cell(Refs, 7, i);

        [MethodImpl(Inline), Op]
        public MemBlock block_d(N0 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemBlock block(N0 n)
            => api.block(Refs, 0);

        [MethodImpl(Inline), Op]
        public MemBlock block_d(N1 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemBlock block(N1 n)
            => api.block(Refs, 1);

        [MethodImpl(Inline), Op]
        public MemBlock block_d(N2 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemBlock block(N2 n)
            => api.block(Refs, 2);

        [MethodImpl(Inline), Op]
        public MemBlock block_d(N3 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemBlock block(N3 n)
            => api.block(Refs, 3);

        [MethodImpl(Inline), Op]
        public MemBlock block_d(N4 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemBlock block(N4 n)
            => api.block(Refs, 4);

        [MethodImpl(Inline), Op]
        public MemBlock block_d(N5 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemBlock block(N5 n)
            => api.block(Refs, 5);

        [MethodImpl(Inline), Op]
        public MemBlock block_d(N6 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemBlock block(N6 n)
            => api.block(Refs, 6);

        [MethodImpl(Inline), Op]
        public MemBlock block_d(N7 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemBlock block(N7 n)
            => api.block(Refs, 7);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N0 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N0 n)
            => api.load(Refs, 0);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N1 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N1 n)
            => api.load(Refs, 1);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N2 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N2 n)
            => api.load(Refs, 2);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N3 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N3 n)
            => api.load(Refs, 3);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N4 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N4 n)
            => api.load(Refs, 4);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N5 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N5 n)
            => api.load(Refs, 5);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N6 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N6 n)
            => api.load(Refs, 6);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N7 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N7 n)
            => api.load(Refs, 7);

        [MethodImpl(Inline), Op]
        public MemBlock block_d(MemStoreIndex n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemBlock block(MemStoreIndex n)
            => api.block(Refs, n);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(MemStoreIndex n, int i)
            => ref Direct.cell(n,i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(MemStoreIndex n, int i)
            => ref api.cell(Refs, n,i);

        [MethodImpl(Inline)]
        public ulong sib_d<N>(N n, int i, byte scale, ushort offset)
            where N : unmanaged, ITypeNat
                => ((ulong)scale)*Direct.cell(n, i) + (ulong)offset; 

        [MethodImpl(Inline), Op]
        public ulong sib_d(N0 n, int i, byte scale, ushort offset)
            => sib_d<N0>(n, i, scale, offset);

        [MethodImpl(Inline), Op]
        public ulong sib_d(N1 n, int i, byte scale, ushort offset)
            => sib_d<N1>(n, i, scale, offset);

        [MethodImpl(Inline)]
        public ulong sib_d(MemStoreIndex n, int i, byte scale, ushort offset)
            => ((ulong)scale)*Direct.cell(n, i) + (ulong)offset;

        [MethodImpl(Inline)]
        public ulong sib(MemStoreIndex n, int i, byte scale, ushort offset)
            => api.sib(Refs, n,i,scale,offset);
    }
}
