//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGrid
    {        
        [MethodImpl(Inline)]
        public static BitGrid32<T> and<T>(BitGrid32<T> gx, BitGrid32<T> gy)
            where T : unmanaged
                => math.and(gx,gy);

        [MethodImpl(Inline)]
        public static BitGrid64<T> and<T>(BitGrid64<T> gx, BitGrid64<T> gy)
            where T : unmanaged
                => math.and(gx,gy);

        [MethodImpl(Inline)]
        public static BitGrid128<T> and<T>(in BitGrid128<T> gx, in BitGrid128<T> gy)
            where T : unmanaged
                => ginx.vand<T>(gx,gy);
    
        [MethodImpl(Inline)]
        public static BitGrid256<T> and<T>(in BitGrid256<T> gx, in BitGrid256<T> gy)
            where T : unmanaged
                => ginx.vand<T>(gx,gy);    

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> and<M,N,T>(in BitGrid128<M,N,T> gx, in BitGrid128<M,N,T> gy)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vand<T>(gx,gy);    

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> and<M,N,T>(in BitGrid256<M,N,T> gx, in BitGrid256<M,N,T> gy)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vand<T>(gx,gy);    
    }
}
