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
        public static Vector256<T> apply<T>(UnaryOp256V f, Vector256<T> x)
            where T : unmanaged
                => f(x.ToFixedV()).ToVector<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> apply<T>(UnaryOp128V f, Vector128<T> x)
            where T : unmanaged
                => f(x.ToFixedV()).ToVector<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> apply<T>(BinaryOp128V f, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => f(x.ToFixedV(), y.ToFixedV()).ToVector<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> apply<T>(BinaryOp256V f, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => f(x.ToFixedV(), y.ToFixedV()).ToVector<T>();

    }
}