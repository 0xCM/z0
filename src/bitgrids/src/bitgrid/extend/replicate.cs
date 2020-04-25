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

    partial class XTend
    {
        public static BitGrid<M,N,T> Replicate<M,N,T>(this BitGrid<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged 
                => new BitGrid<M,N,T>(src.Data.Replicate());

        public static BitGrid<T> Replicate<T>(this BitGrid<T> src)
            where T : unmanaged
                => new BitGrid<T>(src.Data.Replicate(), src.RowCount, src.ColCount);

        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> Replicate<M,N,T>(this BitGrid32<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid32<M,N,T>(src.Content);

        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> Replicate<M,N,T>(this BitGrid64<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid64<M, N, T>(src.Content);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> Replicate<M,N,T>(this BitGrid128<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Content;

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> Replicate<M,N,T>(this BitGrid256<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Content;
    }
}