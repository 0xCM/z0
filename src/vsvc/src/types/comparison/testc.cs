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
        [Closures(AllNumeric), TestC]
        public readonly struct TestC128<T> : ISVBinaryPredicate128D<T>, IBlockedBinaryPred128<T>
            where T : unmanaged
        {
            public const string Name = "vtestc";

            public Vec128Kind<T> VKind => default;

            public static TestC128<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x, Vector128<T> y) => gvec.vtestc(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => default;

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block128<T> x, in Block128<T> y, Span<bit> dst) 
                => VBlocks.testc(x,y,dst);
        }

        [Closures(AllNumeric), TestC]
        public readonly struct TestC256<T> : ISVBinaryPredicate256D<T>, IBlockedBinaryPred256<T>
            where T : unmanaged
        {
            public const string Name = "vtestc";

            public Vec256Kind<T> VKind => default;

            public static TestC256<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x, Vector256<T> y) => gvec.vtestc(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => default;

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block256<T> x, in Block256<T> y, Span<bit> dst) 
                => VBlocks.testc(x,y,dst);
        }
    }
}