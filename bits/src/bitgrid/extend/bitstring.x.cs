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
        public static BitString ToBitString<M,N,T>(this BitGrid<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => g.Data.ToBitString(g.BitCount);

        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitGrid<T> g)
            where T : unmanaged
                => g.Data.ToBitString(g.PointCount);

        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitGrid32<T> g)
            where T : unmanaged
                => g.Data.ToBitString(g.PointCount);


        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid32<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => g.Data.ToBitString(g.PointCount);

        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitGrid64<T> g)
            where T : unmanaged
                => g.Data.ToBitString();

        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid64<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => g.Data.ToBitString(g.PointCount);


        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitGrid128<T> g)
            where T : unmanaged
                => g.Data.ToBitString(g.PointCount);


        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid128<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => g.Data.ToBitString(g.PointCount);

        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitGrid256<T> g)
            where T : unmanaged
                => g.Data.ToBitString(g.PointCount);

        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid256<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => g.Data.ToBitString(g.PointCount);


   }
}