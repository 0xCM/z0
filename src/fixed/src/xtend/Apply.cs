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
        public static Vector512<T> Apply<T>(this UnaryOp512 f, Vector512<T> x)
           where T : unmanaged
                => f(x.ToFixed<T>()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector512<T> Apply<T>(this BinaryOp512 f, Vector512<T> x, Vector512<T> y)
            where T : unmanaged
        {
            var zf = f(Unsafe.As<Vector512<T>,FixedCell512>(ref x), Unsafe.As<Vector512<T>,FixedCell512>(ref y));
            return Unsafe.As<FixedCell512,Vector512<T>>(ref zf);
        }

        [MethodImpl(Inline)]
        public static FixedCell512 ToFixed<T>(this Vector512<T> x)
            where T : unmanaged
                => Unsafe.As<Vector512<T>,FixedCell512>(ref x);
    }
}