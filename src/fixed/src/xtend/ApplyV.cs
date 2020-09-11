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

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static Vector256<T> Apply<T>(this UnaryOp256 f, Vector256<T> x)
            where T : unmanaged
                => CellOps.apply(f,x);

        [MethodImpl(Inline)]
        public static Vector128<T> Apply<T>(this UnaryOp128 f, Vector128<T> x)
            where T : unmanaged
                => CellOps.apply(f,x);

        [MethodImpl(Inline)]
        public static Vector128<T> Apply<T>(this BinaryOp128 f, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => CellOps.apply(f,x,y);

        [MethodImpl(Inline)]
        public static Vector256<T> Apply<T>(this BinaryOp256 f, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => CellOps.apply(f,x,y);
    }
}