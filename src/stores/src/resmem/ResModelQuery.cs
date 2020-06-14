//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    [ApiHost]
    readonly struct ResModelQuery : IApiHost<ResModelQuery>
    {        
        [MethodImpl(Inline)]
        internal ResModelQuery(ResStoreModels models)
        {
            Refs = models.Refs;
            Storage = MemStore.Create(Refs);
            Stores = MemStores.Service;
            Models = models;
        }        
                
        readonly ResStoreModels Models;
        
        readonly MemRef[] Refs;                
        
        readonly MemStore Storage;

        readonly MemStores Stores;

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N0 n)
            => ref Models.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N0 n)
            => ref Stores.cell(Refs, 0,0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N1 n)
            => ref Models.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N1 n)
            => ref Stores.cell(Refs, 1, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N2 n)
            => ref Models.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N2 n)
            => ref Stores.cell(Refs, 2, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N3 n)
            => ref Models.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N3 n)
            => ref Stores.cell(Refs, 3, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N4 n)
            => ref Models.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N4 n)
            => ref Stores.cell(Refs, 4, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N5 n)
            => ref Models.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N5 n)
            => ref Stores.cell(Refs, 5, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N6 n)
            => ref Models.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N6 n)
            => ref Stores.cell(Refs, 6, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N7 n)
            => ref Models.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N7 n)
            => ref Stores.cell(Refs, 7, 0);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N0 n, int i)
            => ref Models.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N0 n, int i)
            => ref Stores.cell(Refs, 0, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N1 n, int i)
            => ref Models.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N1 n, int i)
            => ref Stores.cell(Refs, 1, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N2 n, int i)
            => ref Models.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N2 n, int i)
            => ref Stores.cell(Refs, 2, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N3 n, int i)
            => ref Models.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N3 n, int i)
            => ref Stores.cell(Refs, 3, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N4 n, int i)
            => ref Models.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N4 n, int i)
            => ref Stores.cell(Refs, 4, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N5 n, int i)
            => ref Models.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N5 n, int i)
            => ref Stores.cell(Refs, 5, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N6 n, int i)
            => ref Models.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N6 n, int i)
            => ref Stores.cell(Refs, 6, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N7 n, int i)
            => ref Models.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N7 n, int i)
            => ref Stores.cell(Refs, 7, i);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N0 n)
            => Models.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N0 n)
            => Stores.load(Refs, 0);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N1 n)
            => Models.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N1 n)
            => Stores.load(Refs, 1);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N2 n)
            => Models.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N2 n)
            => Stores.load(Refs, 2);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N3 n)
            => Models.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N3 n)
            => Stores.load(Refs, 3);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N4 n)
            => Models.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N4 n)
            => Stores.load(Refs, 4);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N5 n)
            => Models.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N5 n)
            => Stores.load(Refs, 5);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N6 n)
            => Models.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N6 n)
            => Stores.load(Refs, 6);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N7 n)
            => Models.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N7 n)
            => Stores.load(Refs, 7);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(MemStoreIndex n, int i)
            => ref Models.cell(n,i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(MemStoreIndex n, int i)
            => ref Stores.cell(Refs, n,i);

        [MethodImpl(Inline)]
        public ulong sib_d<N>(N n, int i, byte scale, ushort offset)
            where N : unmanaged, ITypeNat
                => ((ulong)scale)*Models.cell(n, i) + (ulong)offset; 

        [MethodImpl(Inline), Op]
        public ulong sib_d(N0 n, int i, byte scale, ushort offset)
            => sib_d<N0>(n, i, scale, offset);

        [MethodImpl(Inline), Op]
        public ulong sib_d(N1 n, int i, byte scale, ushort offset)
            => sib_d<N1>(n, i, scale, offset);

        [MethodImpl(Inline)]
        public ulong sib_d(MemStoreIndex n, int i, byte scale, ushort offset)
            => ((ulong)scale)*Models.cell(n, i) + (ulong)offset;

        [MethodImpl(Inline)]
        public ulong sib(MemStoreIndex n, int i, byte scale, ushort offset)
            => Stores.sib(Refs, n,i,scale,offset);
    }
}