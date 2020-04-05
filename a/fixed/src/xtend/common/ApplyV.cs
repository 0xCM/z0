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

    partial class XTend
    {
       [MethodImpl(Inline)]
        public static Vector256<T> Apply<T>(this UnaryOp256V f, Vector256<T> x)
            where T : unmanaged
                => f(x.ToFixedV()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector128<T> Apply<T>(this UnaryOp128V f, Vector128<T> x)
            where T : unmanaged
                => ToVector<T>(f(x.ToFixedV()));

        [MethodImpl(Inline)]
        public static Vector128<T> ApplyV<T>(this BinaryOp128 f, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector256<T> ApplyV<T>(this BinaryOp256 f, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();
    }
}