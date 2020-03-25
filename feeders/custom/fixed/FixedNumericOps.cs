//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Custom;

    public static class FixedNumericOps
    {
        [MethodImpl(Inline)]
        public static BinaryOp8 ToFixed(this BinaryOp<byte> f)
            => Fixed.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp8 ToFixed(this BinaryOp<sbyte> f)
            => Fixed.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixed(this BinaryOp<short> f)
            => Fixed.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixed(this BinaryOp<ushort> f)
            => Fixed.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp32 ToFixed(this BinaryOp<int> f)
            => Fixed.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp32 ToFixed(this BinaryOp<uint> f)
            => Fixed.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixed(this BinaryOp<long> f)
            => Fixed.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixed(this BinaryOp<ulong> f)
            => Fixed.fix(f);

        [MethodImpl(Inline)]
        public static Fixed8 ToFixed(this byte x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed8 ToFixed(this sbyte x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed16 ToFixed(this short x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed16 ToFixed(this ushort x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed32 ToFixed(this int x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed32 ToFixed(this uint x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed64 ToFixed(this long x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed64 ToFixed(this ulong x)
            => x;

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
                => Fixed.vector<T>(src);

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