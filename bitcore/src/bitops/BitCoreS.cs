//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public static class BitCoreS
    {
        public readonly struct ByteSwap<T> : IPUnaryOp<T>
            where T : unmanaged        
        {
            public static ByteSwap<T> Op => default;

            public const string Name = "byteswap";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a) => gbits.byteswap(a);
        }
    
        public readonly struct Bfly<N,T> : IPUnaryOp<N,T>
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            public const string Name = "bfly";

            public static Bfly<N,T> Op => default;

            public string Moniker => moniker<N,T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a)
            {
                if(typeof(N) == typeof(N1))
                    return gbits.bfly(n1,a);
                else if(typeof(N) == typeof(N2))
                    return gbits.bfly(n2,a);
                else if(typeof(N) == typeof(N4))
                    return gbits.bfly(n4,a);
                else if(typeof(N) == typeof(N8))
                    return gbits.bfly(n8,a);
                else if(typeof(N) == typeof(N16))
                    return gbits.bfly(n16,a);
                else
                    throw unsupported<N>();
            }            
        }

        public readonly struct Between<T> : IPUnaryRange8Op<T>
            where T : unmanaged        
        {
            public static Between<T> Op => default;

            public const string Name = "between";

            public string Moniker => moniker<T>(Name);

            public T Invoke(T a, byte k1, byte k2) => gbits.between(a,k1,k2);
        }

    }
}