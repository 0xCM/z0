//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Memories;

    [ApiHost]
    readonly struct StoreQueries : IApiHost<StoreQueries>
    {        
        [MethodImpl(Inline)]
        internal StoreQueries(StoreServices src)
        {
            Direct = src;
            Storage = MemoryStore.Service(Store.Data.provided());
        }        
                
        readonly StoreServices Direct;

        readonly MemoryStore Storage;


        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N0 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N0 n)
            => ref Storage.cell(0,0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N1 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N1 n)
            => ref Storage.cell(1,0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N2 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N2 n)
            => ref Storage.cell(2,0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N3 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N3 n)
            => ref Storage.cell(3,0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N4 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N4 n)
            => ref Storage.cell(4,0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N5 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N5 n)
            => ref Storage.cell(5,0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N6 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N6 n)
            => ref Storage.cell(6,0);

        [MethodImpl(Inline), Op]
        public ref readonly byte first_d(N7 n)
            => ref Direct.first(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte first(N7 n)
            => ref Storage.cell(7,0);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N0 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N0 n, int i)
            => ref Storage.cell(0, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N1 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N1 n, int i)
            => ref Storage.cell(1, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N2 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N2 n, int i)
            => ref Storage.cell(2, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N3 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N3 n, int i)
            => ref Storage.cell(3, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N4 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N4 n, int i)
            => ref Storage.cell(4, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N5 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N5 n, int i)
            => ref Storage.cell(5, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N6 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N6 n, int i)
            => ref Storage.cell(6, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(N7 n, int i)
            => ref Direct.cell(n, i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(N7 n, int i)
            => ref Storage.cell(7, i);

        [MethodImpl(Inline), Op]
        public MemoryBlock block_d(N0 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(N0 n)
            => Storage.block(0);

        [MethodImpl(Inline), Op]
        public MemoryBlock block_d(N1 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(N1 n)
            => Storage.block(1);


        [MethodImpl(Inline), Op]
        public MemoryBlock block_d(N2 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(N2 n)
            => Storage.block(2);

        [MethodImpl(Inline), Op]
        public MemoryBlock block_d(N3 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(N3 n)
            => Storage.block(3);

        [MethodImpl(Inline), Op]
        public MemoryBlock block_d(N4 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(N4 n)
            => Storage.block(4);

        [MethodImpl(Inline), Op]
        public MemoryBlock block_d(N5 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(N5 n)
            => Storage.block(5);

        [MethodImpl(Inline), Op]
        public MemoryBlock block_d(N6 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(N6 n)
            => Storage.block(6);

        [MethodImpl(Inline), Op]
        public MemoryBlock block_d(N7 n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(N7 n)
            => Storage.block(7);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N0 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N0 n)
            => Storage.load(0);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N1 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N1 n)
            => Storage.load(1);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N2 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N2 n)
            => Storage.load(2);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N3 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N3 n)
            => Storage.load(3);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N4 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N4 n)
            => Storage.load(4);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N5 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N5 n)
            => Storage.load(5);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N6 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N6 n)
            => Storage.load(6);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load_d(N7 n)
            => Direct.span(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(N7 n)
            => Storage.load(7);

        [MethodImpl(Inline), Op]
        public MemoryBlock block_d(StoreIndex n)
            => Direct.block(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(StoreIndex n)
            => Storage.block(n);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell_d(StoreIndex n, int i)
            => ref Direct.cell(n,i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(StoreIndex n, int i)
            => ref Storage.cell(n,i);

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
        public ulong sib_d(StoreIndex n, int i, byte scale, ushort offset)
            => ((ulong)scale)*Direct.cell(n, i) + (ulong)offset;


        [MethodImpl(Inline)]
        public ulong sib(StoreIndex n, int i, byte scale, ushort offset)
            => Storage.sib(n,i,scale,offset);

    }
}
