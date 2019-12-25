//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    using static BitCoreS;

    public static class BitCore
    {
        [MethodImpl(Inline)]
        public static ByteSwap<T> byteswap<T>(T t = default)
            where T : unmanaged        
                => ByteSwap<T>.Op;

        [MethodImpl(Inline)]
        public static Bfly<N,T> bfly<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged        
                => Bfly<N,T>.Op;

        [MethodImpl(Inline)]
        public static Between<T> between<T>(T t = default)
            where T : unmanaged        
                => Between<T>.Op;

    }
}