//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    partial class BitGrid
    {                
        public static BitGrid<M,N,T> replicate<M,N,T>(BitGrid<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged 
                => new BitGrid<M,N,T>(src.Content.Replicate());

        public static BitGrid<T> replicate<T>(BitGrid<T> src)
            where T : unmanaged
                => new BitGrid<T>(src.Content.Replicate(), src.RowCount, src.ColCount);

        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> replicate<M,N,T>(BitGrid32<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid32<M,N,T>(src.Content);

        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> replicate<M,N,T>(BitGrid64<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid64<M, N, T>(src.Content);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> replicate<M,N,T>(in BitGrid128<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Content;

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> replicate<M,N,T>(in BitGrid256<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid256<M,N,T>(src.Content);
    }
}