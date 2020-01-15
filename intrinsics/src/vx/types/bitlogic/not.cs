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
        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Not128<T> : IVUnaryOp128D<T>
            where T : unmanaged
        {
            public const string Name = "vnot";

            public static Not128<T> Op => default;

            static N128 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => ginx.vnot(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.not(a);
        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Not256<T> : IVUnaryOp256D<T>
            where T : unmanaged
        {
            public const string Name = "vnot";

            public static Not256<T> Op => default;

            static N256 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) => ginx.vnot(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.not(a);
        }

   }

}