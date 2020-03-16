//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static Root;

    partial class FixedVectorOps
    {
       [MethodImpl(Inline)]
        public static Vector128<T> ToVector<T>(this in Fixed128 src)
            where T : unmanaged
                => Unsafe.As<Fixed128,Vector128<T>>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        public static Fixed128 ToFixed<T>(this Vector128<T> x)
            where T : unmanaged
                => Unsafe.As<Vector128<T>,Fixed128>(ref x);

        [MethodImpl(Inline)]
        public static Vector128<T> ToVector<T>(this in Fixed128V src)
            where T : unmanaged
                => src.data.As<ulong,T>();

        [MethodImpl(Inline)]
        public static Fixed128V ToFixedV<T>(this Vector128<T> x)
            where T : unmanaged
                => Fixed128V.From(x);

       [MethodImpl(Inline)]
        public static Fixed256 ToFixed<T>(this Vector256<T> x)
            where T : unmanaged
                => Unsafe.As<Vector256<T>,Fixed256>(ref x);

        [MethodImpl(Inline)]
        public static Vector256<T> ToVector<T>(this in Fixed256 src)
            where T : unmanaged
                => Unsafe.As<Fixed256,Vector256<T>>(ref Unsafe.AsRef(in src));

    }
}