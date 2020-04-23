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
        [Closures(Integers), Select]
        public readonly struct Select128<T> : ISVTernaryOp128D<T>
            where T : unmanaged
        {
            public const string Name = "vselect";

            public static Select128<T> Op => default;

            public Vec128Kind<T> VKind => default;
 
            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y, Vector128<T> z) => gvec.vselect(x,y,z);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b, T c) => gmath.select(a,b,c);
        }

        [Closures(Integers), Select]
        public readonly struct Select256<T> : ISVTernaryOp256D<T>
            where T : unmanaged
        {
            public const string Name = "vselect";

            public static Select256<T> Op => default;

            public Vec256Kind<T> VKind => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y, Vector256<T> z) => gvec.vselect(x,y,z);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b, T c) => gmath.select(a,b,c);
        }
    }
}