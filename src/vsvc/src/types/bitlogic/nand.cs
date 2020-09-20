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
    using static Memories;

    partial class VServices
    {
        [Closures(Integers), Nand]
        public readonly struct Nand128<T> : IBinaryOp128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => gvec.vnand(x,y);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) => gmath.nand(a,b);
        }

        [Closures(Integers), Nand]
        public readonly struct Nand256<T> : IBinaryOp256D<T>
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => gvec.vnand(x,y);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) => gmath.nand(a,b);

        }
    }
}