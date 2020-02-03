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
        [NumericClosures(NumericKind.All)]
        public readonly struct TestZ128<T> : IVBinPred128D<T>, IBinaryBlockedPred128<T>
            where T : unmanaged
        {
            public const string Name = "vtestz";

            static N128 w => default;

            public static TestZ128<T> Op => default;

            public OpIdentity Moniker => Identity.operation<T>(Name,w);

            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x,Vector128<T> y) => ginx.vtestz(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => default;

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block128<T> x, in Block128<T> y, Span<bit> dst) 
                => vblocks.vtestz(x,y,dst);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct TestZ256<T> : IVBinPred256<T>, IBinaryBlockedPred256<T>
            where T : unmanaged
        {
            public const string Name = "vtestz";

            static N256 w => default;

            public static TestZ256<T> Op => default;

            public OpIdentity Moniker => Identity.operation<T>(Name,w);

            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x,Vector256<T> y) => ginx.vtestz(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => default;

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block256<T> x, in Block256<T> y, Span<bit> dst) 
                => vblocks.vtestz(x,y,dst);

        }
   }
}