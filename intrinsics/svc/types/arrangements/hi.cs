//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial class VSvcHosts
    {
        public readonly struct Hi128<T> : IVUnaryOp128<T>
            where T : unmanaged
        {
            public const string Name = "vhi";

            public static VKT.Vec128<T> hk => default;

            public static Hi128<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => ginx.vhi(x);            
        }

        public readonly struct Hi256<T> : IVReducer256<T>
            where T : unmanaged
        {
            public const string Name = "vhi";

            public static VKT.Vec256<T> hk => default;

            public static Hi256<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted(Name,hk);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector256<T> x) => ginx.vhi(x);
           
        }
    }
}