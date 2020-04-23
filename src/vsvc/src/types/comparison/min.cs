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
    
    using K = Kinds;


    partial class VSvcHosts
    {
        [Closures(AllNumeric), Min]
        public readonly struct Min128<T> : ISVBinaryOp128D<T>
            where T : unmanaged
        {
            public const string Name = "vmin";

            public Vec128Kind<T> VKind => default;

            public static Min128<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            public K.BinaryOpClass<T> Class => default;

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => gvec.vmin(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.min(a,b);

        }

        [Closures(AllNumeric), Min]
        public readonly struct Min256<T> : ISVBinaryOp256D<T>
            where T : unmanaged
        {
            public const string Name = "vmin";
            
            public Vec256Kind<T> VKind => default;

            public static Min256<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => gvec.vmin(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.min(a,b);

        }
    }
}