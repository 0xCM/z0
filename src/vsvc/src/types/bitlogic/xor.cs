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
        [Closures(Integers), Xor]
        public readonly struct Xor128<T> : ISVBinaryOp128D<T>
            where T : unmanaged
        {
            public const string Name = "vxor";

            public static Xor128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => gvec.vxor(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.xor(a,b);
        }

        [Closures(Integers), Xor]
        public readonly struct Xor256<T> : ISVBinaryOp256D<T>
            where T : unmanaged
        {
            public const string Name = "vxor";

            public static Xor256<T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => gvec.vxor(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.xor(a,b);
        }
   }
}