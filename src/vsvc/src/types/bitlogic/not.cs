//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static SFx;

    partial class VServices
    {
        [Closures(Integers), Not]
        public readonly struct Not128<T> : IUnaryOp128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x)
                => gcpu.vnot(x);

            [MethodImpl(Inline)]
            public T Invoke(T a)
                => gmath.not(a);
        }

        [NumericClosures(Integers), Not]
        public readonly struct Not256<T> : IUnaryOp256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x)
                => gcpu.vnot(x);

            [MethodImpl(Inline)]
            public T Invoke(T a)
                => gmath.not(a);
        }
   }
}