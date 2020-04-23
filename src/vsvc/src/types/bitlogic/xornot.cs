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
    using static Memories;

    partial class VSvcHosts
    {
        [Closures(Integers)]
        public readonly struct XorNot128<T> : IVSvcBinaryOp128<T>
            where T : unmanaged
        {
            public const string Name = "vxornot";

            public static XorNot128<T> Op => default;

            public Vec128Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => gvec.vxornot(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.xornot(a,b);
        }

        [NumericClosures(Integers)]
        public readonly struct XorNot256<T> : IVSvcBinaryOp256<T>
            where T : unmanaged
        {
            public const string Name = "vxornot";

            public static XorNot256<T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => gvec.vxornot(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.xornot(a,b);

        }
    }
}