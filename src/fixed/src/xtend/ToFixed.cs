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

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 ToFixed<T>(this Func<Vector128<T>, Vector128<T>> f)
            where T : unmanaged
                => Fixed.fix(f);

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 ToFixed<T>(this Func<Vector128<T>,Vector128<T>,Vector128<T>> f)
            where T : unmanaged
                => Fixed.fix(f);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 ToFixed<T>(this Func<Vector256<T>,Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => Fixed.fix(f);
 
        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp256 ToFixed<T>(this Func<Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => Fixed.fix(f);

        [MethodImpl(Inline)]
        public static Fixed128 ToFixed<T>(this Vector128<T> x)
            where T : unmanaged
                => Fixed.fix(x);

        [MethodImpl(Inline)]
        public static Fixed256 ToFixed<T>(this Vector256<T> x)
            where T : unmanaged
                => Fixed.fix(x);
    }
}