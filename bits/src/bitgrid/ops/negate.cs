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
        public static BitGrid32<T> negate<T>(BitGrid32<T> gx)
            where T : unmanaged
                => math.negate(gx);

        [MethodImpl(Inline)]
        public static BitGrid64<T> negate<T>(BitGrid64<T> gx)
            where T : unmanaged
                => math.negate(gx);

        [MethodImpl(Inline)]
        public static BitGrid128<T> negate<T>(in BitGrid128<T> gx)
            where T : unmanaged
                => ginx.vnegate<T>(gx);

        [MethodImpl(Inline)]
        public static BitGrid256<T> negate<T>(in BitGrid256<T> gx)
            where T : unmanaged
                => ginx.vnegate<T>(gx);

        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> negate<M,N,T>(in BitGrid128<M,N,T> gx)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vnegate<T>(gx);    

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> negate<M,N,T>(in BitGrid256<M,N,T> gx)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ginx.vnegate<T>(gx);    

    }
}
