//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Seed;

    partial class XTend
    {
        // [MethodImpl(Inline)]
        // public static Vector512<T> ToVector<T>(this in Fixed512V src)
        //     where T : unmanaged
        //         => new Vector512<T>(src.Lo<T>(), src.Hi<T>());

        [MethodImpl(Inline)]
        public static Vector512<T> Apply<T>(this UnaryOp512V f, Vector512<T> x)
           where T : unmanaged
                => f(x.ToFixed<T>()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector512<T> Apply<T>(this BinaryOp512V f, Vector512<T> x, Vector512<T> y)
            where T : unmanaged
        {
            var zf = f(Unsafe.As<Vector512<T>,Fixed512V>(ref x), Unsafe.As<Vector512<T>,Fixed512V>(ref y));
            return Unsafe.As<Fixed512V,Vector512<T>>(ref zf);
        }              
 
        [MethodImpl(Inline)]
        public static Fixed512V ToFixed<T>(this Vector512<T> x)
            where T : unmanaged
                => Unsafe.As<Vector512<T>,Fixed512V>(ref x);
    }
}