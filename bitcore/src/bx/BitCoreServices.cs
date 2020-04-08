//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;

    [ApiHost,ApiServiceProvider("bitcore.services")]
    public partial class BitCoreServices : IApiServiceProvider<BitCoreServices>
    {

    }
        
    public partial class BitCoreServices
    {
        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static ByteSwap<T> byteswap<T>(T t = default)
            where T : unmanaged        
                => ByteSwap<T>.Op;

        [MethodImpl(Inline)]
        public static Bfly<N,T> bfly<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged        
                => Bfly<N,T>.Op;

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static Between<T> between<T>(T t = default)
            where T : unmanaged        
                => Between<T>.Op;

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static BitSlice<T> bitslice<T>(T t = default)
            where T : unmanaged        
                => BitSlice<T>.Op;

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static BitSlice<T> bitslice2<T>(T t = default)
            where T : unmanaged        
                => ApiServices.Service<BitSlice<T>>();

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static PopCount<T> pop<T>(T t = default)
            where T : unmanaged        
                => PopCount<T>.Op;

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static Dot<T> dot<T>(T t = default)
            where T : unmanaged        
                => Dot<T>.Op;
    }
}