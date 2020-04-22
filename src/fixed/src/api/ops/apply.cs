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
    using static Memories;

    partial class Fixed    
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> apply<T>(UnaryOp128 f, Vector128<T> x)
            where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> apply<T>(BinaryOp128 f, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();  

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> apply<T>(UnaryOp256 f, Vector256<T> x)
           where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> apply<T>(UnaryOp256V f, Vector256<T> x)
            where T : unmanaged
                => f(x.ToFixedV()).ToVector<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> apply<T>(UnaryOp128V f, Vector128<T> x)
            where T : unmanaged
                => f(x.ToFixedV()).ToVector<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> applyV<T>(BinaryOp128 f, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> apply<T>(BinaryOp256 f, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> apply2<T>(BinaryOp256 f, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            var zf = f(Unsafe.As<Vector256<T>,Fixed256>(ref x), Unsafe.As<Vector256<T>,Fixed256>(ref y));
            return Unsafe.As<Fixed256,Vector256<T>>(ref zf);
        }          
    }
}