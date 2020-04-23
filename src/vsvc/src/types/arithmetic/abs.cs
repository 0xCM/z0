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
        [Closures(SignedInts), Abs]
        public readonly struct Abs128<T> : ISVUnaryOp128D<T>
            where T : unmanaged
        {
            public const string Name = "vabs";

            public Vec128Kind<T> VKind => default;
            
            public static Abs128<T> Op => default;
             
            public OpIdentity Id => Identify.sfunc(Name, VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) 
                => gvec.vabs(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) 
                => gmath.abs(a);
        }

        [Closures(SignedInts), Abs]
        public readonly struct Abs256<T> : ISVUnaryOp256D<T>
            where T : unmanaged
        {
            public const string Name = "vabs";
             
            public Vec256Kind<T> VKind => default;

            public static Abs256<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) 
                => gvec.vabs(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) 
                => gmath.abs(a);
        }
    }
}