//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static Seed;

    partial class VSvcHosts
    {
        [Closures(AllNumeric), Add]
        public readonly struct Add128<T> : ISVBinaryOp128D<T>
            where T : unmanaged
        {
            public const string Name = "vadd";

            public Vec128Kind<T> VKind => default;

            public static Add128<T> Op => default;
             
            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) 
                => gvec.vadd(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) 
                => gmath.add(a,b);
        }

        [Closures(AllNumeric), Add]
        public readonly struct Add256<T> : ISVBinaryOp256D<T>
            where T : unmanaged
        {
            public const string Name = "vadd";

            public Vec256Kind<T> VKind => default;

            public static Add256<T> Op => default;
            
            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) 
                => gvec.vadd(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) 
                => gmath.add(a,b);
        }
    }
}