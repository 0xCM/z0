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

    partial class VFTypes
    {
        [NumericClosures(NumericKind.All)]
        public readonly struct Min128<T> : IVBinOp128D<T>, IBinaryBlockedOp128<T>
            where T : unmanaged
        {
            public const string Name = "vmin";

            static N128 w => default;

            public static Min128<T> Op => default;

            public OpIdentity Id => NaturalIdentity.contracted<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => ginx.vmin(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.min(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c)            
                => ref vblocks.vmin(a,b,c);

        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Min256<T> : IVBinOp256D<T>, IBinaryBlockedOp256<T>
            where T : unmanaged
        {
            public const string Name = "vmin";
            
            static N256 w => default;

            public static Min256<T> Op => default;

            public OpIdentity Id => NaturalIdentity.contracted<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => ginx.vmin(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.min(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c)            
                => ref vblocks.vmin(a,b,c);

        }
    }
}