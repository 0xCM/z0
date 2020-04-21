//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class VSvcHosts
    {
        [NumericClosures(NumericKind.All)]
        public readonly struct NonZ128<T> : ISVUnaryPredicate128DApi<T>, ISBUnaryPred128Api<T>
            where T : unmanaged
        {
            public static NonZ128<T> Op => default;

            public const string Name = "vnonz";

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identities.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x) => gvec.vnonz(x);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a) => gmath.nonz(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block128<T> x, Span<bit> dst) 
                => gblocks.nonz(x,dst);

        }

        [NumericClosures(NumericKind.All)]
        public readonly struct NonZ256<T> : ISVUnaryPredicate256DApi<T>, ISBUnaryPred256Api<T>
            where T : unmanaged
        {
            public const string Name = "vnonz";

            public Vec256Kind<T> VKind => default;

            public static NonZ256<T> Op => default;

            public OpIdentity Id => Identities.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x) => gvec.vnonz(x);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a) => gmath.nonz(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block256<T> x, Span<bit> dst) 
                => gblocks.nonz(x,dst);

        }
    }
}