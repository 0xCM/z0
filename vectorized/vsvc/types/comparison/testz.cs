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
        [NumericClosures(NumericKind.All)]
        public readonly struct TestZ128<T> : ISVBinaryPredicate128DApi<T>, ISBBinaryPred128Api<T>
            where T : unmanaged
        {
            public const string Name = "vtestz";

            public Vec128Kind<T> VKind => default;

            public static TestZ128<T> Op => default;

            public OpIdentity Id => OpIdentity.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x,Vector128<T> y) => gvec.vtestz(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => default;

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block128<T> x, in Block128<T> y, Span<bit> dst) 
                => gblocks.vtestz(x,y,dst);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct TestZ256<T> : ISVBinaryPredicate256Api<T>, ISBBinaryPred256Api<T>
            where T : unmanaged
        {
            public const string Name = "vtestz";

            public Vec256Kind<T> VKind => default;

            public static TestZ256<T> Op => default;

            public OpIdentity Id => OpIdentity.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x,Vector256<T> y) => gvec.vtestz(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => default;

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block256<T> x, in Block256<T> y, Span<bit> dst) 
                => gblocks.vtestz(x,y,dst);

        }
   }
}