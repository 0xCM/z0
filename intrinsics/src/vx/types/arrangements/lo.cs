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
        public readonly struct Lo128<T> : IVUnaryOp128<T>
            where T : unmanaged
        {
            public const string Name = "vhi";

            public static HK.Vec128<T> hk => default;

            public static Lo128<T> Op => default;

            public Moniker Moniker => moniker(Name,hk);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) 
                => ginx.vlo(x);            
        }

        public readonly struct Lo256<T> : IVReducer256<T>
            where T : unmanaged
        {
            public const string Name = "vlo";

            public static HK.Vec256<T> hk => default;

            public static Lo256<T> Op => default;

            public Moniker Moniker => moniker(Name,hk);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector256<T> x) 
                => ginx.vlo(x);
           
        }
    }
}