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
    public readonly struct StoreQueries : IApiHost<StoreQueries>
    {        
        [MethodImpl(Inline)]
        internal StoreQueries(StoreServices src)
        {
            Store = src;
        }        
                
        public readonly StoreServices Store;

        [MethodImpl(Inline)]
        public unsafe MemoryRef @ref<N>(N n = default)
            where N : unmanaged, ITypeNat
                => Store.@ref(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(W8 w, duet n)
            => Store.block(n);
        
        [MethodImpl(Inline), Op]
        public MemoryBlock block(W8 w, N0 n)
            => Store.block(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(W8 w, N1 n)
            => Store.block(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(W8 w, N2 n)
            => Store.block(n);

        [MethodImpl(Inline), Op]
        public MemoryBlock block(W8 w, N3 n)
            => Store.block(n);

        [MethodImpl(Inline)]
        public ulong address(int n, int i, byte scale, byte offset)
            => ((ulong)scale)*Store.cell(n, i) + (ulong)offset;

        [MethodImpl(Inline)]
        public ulong address<N>(N n, int i, byte scale, byte offset)
            where N : unmanaged, ITypeNat
                => ((ulong)scale)*Store.cell(n, i) + (ulong)offset; 

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(duet n, int i)
            => ref Store.cell(n,i);

        // [MethodImpl(Inline), Op]
        // public ref readonly byte cell(in MemoryBlock n, int i)
        //     => ref T.cell(n,i);

        // [MethodImpl(Inline), Op]
        // public ReadOnlySpan<byte> spanref(N0 n)
        //     => T.load(@ref(n));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> span(N0 n)
            => Store.span8(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> span(W8 w, N0 n)
            => Store.span(w, n, Numeric.kind<byte>());

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> span(N1 n)
            => Store.span8(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> span(N2 n)
            => Store.span8(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> span(N3 n)
            => Store.span8(n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<ushort> span(W16 w, N0 n)
            => Store.span(w, n, Numeric.kind<ushort>());

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<ushort> span(W16 w, N1 n)
            => Store.span(w, n, Numeric.kind<ushort>());

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<uint> span(W32 w, N0 n)
            => Store.span(w, n, Numeric.kind<uint>());

        [MethodImpl(Inline), Op]
        public ulong address(N0 n, sextet i, byte scale, byte offset)
            => address<N0>(n, i, scale, offset);

        [MethodImpl(Inline), Op]
        public ulong address(N1 n, sextet i, byte scale, byte offset)
            => address<N1>(n, i, scale, offset);

        // [MethodImpl(Inline), Op]
        // public ulong address(N2 n, sextet i, byte scale, byte offset)
        //     => T.address(Store.@ref(n), i,scale, offset);

        // [MethodImpl(Inline), Op]
        // public ulong address(N3 n, sextet i, byte scale, byte offset)
        //     => T.address(Store.@ref(n), i,scale, offset);
    }
}
