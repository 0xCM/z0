//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static SFx;

    partial class VServices
    {
        [Closures(Integers), Select]
        public readonly struct Select128<T> : ITernaryOp128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y, Vector128<T> z)
                => gcpu.vselect(x,y,z);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b, T c)
                => gbits.select(a,b,c);
        }

        [Closures(Integers), Select]
        public readonly struct Select256<T> : ITernaryOp256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y, Vector256<T> z)
                => gcpu.vselect(x,y,z);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b, T c)
                => gbits.select(a,b,c);
        }
    }
}