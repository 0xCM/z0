//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
                
    using static Seed;
    using static ApiUtility;
        
    static class ApiUtility
    {
        /// <summary>
        /// Instantiates a strongly-typed operation host
        /// </summary>
        /// <typeparam name="S">The host type</typeparam>
        [MethodImpl(Inline)]
        public static S ApiSvc<S>()
            where S : unmanaged, ISFunc    
                => default(S);        

    }   

    [ApiServiceFactory]
    public partial class BC : IApiService<BC>
    {
        [MethodImpl(Inline)]
        public static ByteSwap<T> byteswap<T>(T t = default)
            where T : unmanaged        
                => ApiSvc<ByteSwap<T>>();

        [MethodImpl(Inline)]
        public static Bfly<N,T> bfly<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged        
                => ApiSvc<Bfly<N,T>>();

        [MethodImpl(Inline)]
        public static Between<T> between<T>(T t = default)
            where T : unmanaged        
                => ApiSvc<Between<T>>();

        [MethodImpl(Inline)]
        public static BitSlice<T> bitslice<T>(T t = default)
            where T : unmanaged        
                => ApiSvc<BitSlice<T>>();

        [MethodImpl(Inline)]
        public static PopCount<T> pop<T>(T t = default)
            where T : unmanaged        
                => ApiSvc<PopCount<T>>();

        [MethodImpl(Inline)]
        public static Dot<T> dot<T>(T t = default)
            where T : unmanaged        
                => ApiSvc<Dot<T>>();
    }
}