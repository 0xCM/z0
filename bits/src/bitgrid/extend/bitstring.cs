//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGridX
    {   

        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid<M,N,T> src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.ToBitString(BitCalcs.points(m,n));

        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitGrid<T> src)
            where T : unmanaged
                => src.Data.ToBitString(src.RowCount * src.Width);

        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid32<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => g.Scalar.ToBitString();


        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid64<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => g.Scalar.ToBitString();


    }

}