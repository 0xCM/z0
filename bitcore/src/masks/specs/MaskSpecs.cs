//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class MaskSpecs
    {                
        [MethodImpl(Inline)]
        public static LsbMask<F,D,T> lsb<F,D,T>(F f = default, D d = default, T t = default) 
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static MsbMask<F,D,T> msb<F,D,T>(F f = default, D d = default, T t = default) 
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static JsbMask<F,D,T> jsb<F,D,T>(F f = default, D d = default, T t = default) 
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static CentralMask<F,D,T> central<F,D,T>(F f = default, D d = default, T t = default) 
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static IndexMask<N,T> index<N,T>(N n = default, T t = default) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => default;

    }   
}