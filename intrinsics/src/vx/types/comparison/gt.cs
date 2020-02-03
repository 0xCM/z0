//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class VXTypes
    {
        [NumericClosures(NumericKind.All)]
        public readonly struct Gt128<T> : IVBinOp128D<T>, IBinaryBlockedOp128<T>
            where T : unmanaged
        {
            public const string Name = "vgt";

            static N128 w => default;

            public static Gt128<T> Op => default;

            public Moniker Moniker => identify<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => ginx.vgt(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.gtz(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c)            
                => ref vblocks.vgt(a,b,c);


        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Gt256<T> : IVBinOp256D<T>, IBinaryBlockedOp256<T>
            where T : unmanaged
        {
            public const string Name = "vgt";

            static N256 w => default;

            public static Gt256<T> Op => default;

            public Moniker Moniker => identify<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => ginx.vgt(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.gtz(a,b);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c)            
                => ref vblocks.vgt(a,b,c);

        } 
    }
}