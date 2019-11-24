//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitGridX
    {
        [MethodImpl(Inline)]
        public static RowBits<T> Replicate<T>(this RowBits<T> src, bool structureOnly = false)
            where T : unmanaged
                => new RowBits<T>(src.data.Replicate(structureOnly));

        [MethodImpl(NotInline)]
        public static BitGrid<T> Replicate<T>(this BitGrid<T> src)
            where T : unmanaged
                => new BitGrid<T>(src.Data.Replicate(), src.RowCount, src.Width);

        [MethodImpl(NotInline)]
        public static BitGrid<M,N,T> Replicate<M,N,T>(this BitGrid<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged 
                => new BitGrid<M,N,T>(src.Data.Replicate());

        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> Replicate<M,N,T>(this BitGrid64<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid64<M, N, T>(src.Scalar);

        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> Replicate<M,N,T>(this BitGrid32<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid32<M, N, T>(src.Scalar);

    }

}