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
    using System.Reflection;

    using static zfunc;

    public static class FixedXX
    {
        /// <summary>
        /// Determines whether a method is classified as a span op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsSpanOp(this MethodInfo m)
            => m.Attributed<SpanOpAttribute>();

        [MethodImpl(Inline)]
        public static Vector128<T> ToVector<T>(this in Fixed128 src)
            where T : unmanaged
                => Unsafe.As<Fixed128,Vector128<T>>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        public static Vector256<T> ToVector<T>(this in Fixed256 src)
            where T : unmanaged
                => Unsafe.As<Fixed256,Vector256<T>>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        public static Fixed128 ToFixed<T>(this Vector128<T> x)
            where T : unmanaged
                => Unsafe.As<Vector128<T>,Fixed128>(ref x);

        [MethodImpl(Inline)]
        public static Fixed256 ToFixed<T>(this Vector256<T> x)
            where T : unmanaged
                => Unsafe.As<Vector256<T>,Fixed256>(ref x);

        [MethodImpl(Inline)]
        public static Fixed8 ToFixed(this byte src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed8 ToFixed(this sbyte src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed16 ToFixed(this ushort src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed16 ToFixed(this short src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed32 ToFixed(this int src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed32 ToFixed(this uint src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed64 ToFixed(this long src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed64 ToFixed(this ulong src)
            => src;

        [MethodImpl(Inline)]
        public static Vector256<T> Apply<T>(this UnaryOp256 f, Vector256<T> x)
           where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector256<T> Apply<T>(this BinaryOp256 f, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            var zf = f(Unsafe.As<Vector256<T>,Fixed256>(ref x), Unsafe.As<Vector256<T>,Fixed256>(ref y));
            return Unsafe.As<Fixed256,Vector256<T>>(ref zf);
        }

        [MethodImpl(Inline)]
        public static Vector128<T> Apply<T>(this UnaryOp128 f, Vector128<T> x)
            where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector128<T> Apply<T>(this BinaryOp128 f, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();
    }

}