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
        [NumericClosures(NumericKind.Integers)]
        public readonly struct Or128<T> : ISVBinaryOp128DApi<T>, IBinaryBlockedOp128<T>
            where T : unmanaged
        {
            public const string Name = "vor";

            public static Or128<T> Op => default;

            static N128 w => default;

            public OpIdentity Id => NaturalIdentity.contracted<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => gvec.vor(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.or(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c)            
                => ref gblocks.or(a,b,c);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Or256<T> : ISVBinaryOp256DApi<T>, IBinaryBlockedOp256<T>
            where T : unmanaged
        {
            public const string Name = "vor";

            public static Or256<T> Op => default;

            static N256 w => default;

            public OpIdentity Id => NaturalIdentity.contracted<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => gvec.vor(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.or(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c)            
                => ref gblocks.or(a,b,c);
        }
    }
}