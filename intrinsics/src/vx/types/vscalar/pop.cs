//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class VXTypes
    {
        public readonly struct Pop128<T> : IVTernaryScalar128D<T,uint>
            where T : unmanaged
        {
            public static Pop128<T> Op => default;

            public const string Name = "vpop";

            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public uint Invoke(Vector128<T> x,Vector128<T> y,Vector128<T> z) => ginx.vpop(x,y,z);
            
            [MethodImpl(Inline)]
            public uint InvokeScalar(T a, T b, T c) => gbits.pop(a,b,c);
        }

        public readonly struct Pop256<T> : IVTernaryScalar256D<T,uint>
            where T : unmanaged
        {
            public static Pop256<T> Op => default;

            public const string Name = "vpop";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public uint Invoke(Vector256<T> x,Vector256<T> y,Vector256<T> z) => ginx.vpop(x,y,z);

            [MethodImpl(Inline)]
            public uint InvokeScalar(T a, T b, T c) => gbits.pop(a,b,c);
        }    
    }
}