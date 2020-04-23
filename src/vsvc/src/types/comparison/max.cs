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
        [Closures(AllNumeric), Max]
        public readonly struct Max128<T> : ISVBinaryOp128D<T>
            where T : unmanaged
        {
            public const string Name = "vmax";

            public Vec128Kind<T> VKind => default;

            public static Max128<T> Op => default;

            public OpIdentity Id 
                => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) 
                => gvec.vmax(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) 
                => gmath.max(a,b);
        }

        [Closures(AllNumeric), Max]
        public readonly struct Max256<T> : ISVBinaryOp256D<T>
            where T : unmanaged
        {
            public const string Name = "vmax";

            public static Max256<T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id 
                => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) 
                => gvec.vmax(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) 
                => gmath.max(a,b);
        }
    }
}