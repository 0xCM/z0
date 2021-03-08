//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using U = uint4;
    using W = W4;

    partial struct UI
    {
        /// <summary>
        /// Reduces the source value to a width-identified integer via modular arithmetic
        /// </summary>
        /// <param name="src">The input value</param>
        /// <param name="w">The target bit-width</param>
        [MethodImpl(Inline), Op]
        public static U reduce(byte src, W w)
            => new U(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref S edit<S>(in U src)
            where S : unmanaged
                => ref @as<U,S>(src);

        /// <summary>
        /// Reinterprets an input reference as as a mutable <see cref='Z0.uint3'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref U edit<S>(in S src, W dst)
            where S : unmanaged
                => ref @as<S,U>(src);

        [MethodImpl(Inline), Op]
        public static U maxval(W w)
            => maxval<U>();

        [MethodImpl(Inline), Op]
        public static U inc(U x)
            => !x.IsMax ? new U(Bytes.add(x.data, 1), false) : U.Min;

        [MethodImpl(Inline), Op]
        public static U dec(U x)
            => !x.IsMin ? new U(Bytes.sub(x.data, 1), false) : U.Max;

        /// <summary>
        /// Converts a source integral value to an enum value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="K">The target enum  type</typeparam>
        [MethodImpl(Inline)]
        public static ref K refine<K>(in U src)
            where K : unmanaged, Enum
                => ref @as<uint4,K>(src);

        /// <summary>
        /// Converts an enum to a width-identified integer
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static U scalar<K>(in K src, W w)
            where K : unmanaged, Enum
                => new U(@as<K,byte>(src));

        /// <summary>
        /// Injects the source value directly into the width-identified target, bypassing bounds-checks
        /// </summary>
        /// <param name="src">The value to inject</param>
        /// <param name="w">The target bit-width</param>
        [MethodImpl(Inline)]
        public static U inject(byte src, W w)
            => new U(src, false);

        /// <summary>
        /// Shifts the source a rightwards by a specified bit count and shears the result to a specified width
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="n">The number of bits to shift</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static U srl(byte src, N4 n, W w)
            => crop4(Bytes.srl(src,4));

        /// <summary>
        /// Creates a 4-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint4(bool src)
            => wrap4(@byte(src));

        /// <summary>
        /// Creates a 4-bit unsigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint4(byte src)
            => new U(src);

        /// <summary>
        /// Creates a 4-bit unsigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint4(sbyte src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 4-bit unsigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint4(ushort src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 4-bit unsigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint4(short src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 4-bit unsigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint4(int src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 4-bit unsigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint4(uint src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 4-bit unsigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint4(long src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 4-bit unsigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint4(ulong src)
            => new U((byte)((byte)src & U.MaxLiteral));

        /// <summary>
        /// Creates a 4-bit unsigned integer from a 4-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        /// <param name="x2">The term at index 2</param>
        /// <param name="x3">The term at index 3</param>
        [MethodImpl(Inline), Op]
        public static U uint4(BitState x0, BitState x1 = default, BitState x2 = default, BitState x3 = default)
             => wrap4(Bytes.or(
                 Bytes.sll((byte)x0, 0),
                 Bytes.sll((byte)x1, 1),
                 Bytes.sll((byte)x2, 2),
                 Bytes.sll((byte)x3, 3)
                 ));

        [MethodImpl(Inline), Op]
        public static U add(U x, U y)
        {
            var d = (byte)(x.data +y.data);
            var result = Bytes.gteq(d, U.Mod) ? Bytes.sub(d, U.Mod) : d;
            return new U(result, true);
        }

        [MethodImpl(Inline), Op]
        public static U sub(U x, U y)
        {
            var delta = x.data - y.data;
            if(delta < 0)
                return wrap4((byte)(delta + U.Mod));
            else
                return wrap4((byte)delta);
        }

        [MethodImpl(Inline), Op]
        public static U mul(U a, U b)
            => reduce4((byte)(a.data * b.data));

        [MethodImpl(Inline), Op]
        public static U and(U a, U b)
            => wrap4(a.data & b.data);

        [MethodImpl(Inline), Op]
        public static U or(U lhs, U rhs)
            => wrap4(lhs.data | rhs.data);

        [MethodImpl(Inline), Op]
        public static U xor(U lhs, U rhs)
            => wrap4(lhs.data ^ rhs.data);

        [MethodImpl(Inline), Op]
        public static U not(U a)
            => wrap4(~a.data & U.MaxLiteral);

        [MethodImpl(Inline), Op]
        public static U hi(U src)
            => wrap4(src.data >> 2 & 0b11);

        [MethodImpl(Inline), Op]
        public static U lo(U src)
            => wrap4(src.data & 0b11);

        [MethodImpl(Inline), Op]
        public static bit test(U src, byte pos)
            => bit.test(src,pos);

        [MethodImpl(Inline), Op]
        public static U set(U src, byte pos, bit state)
        {
            if(pos < U.Width)
                return wrap4(bit.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline)]
        public static bool eq(U x, U y)
            => x.data == y.data;

        [MethodImpl(Inline), Op]
        internal static byte reduce4(byte x)
            => (byte)(x % U.Mod);

        [MethodImpl(Inline)]
        internal static U wrap4(int src)
            => new U((byte)src, false);

        [MethodImpl(Inline)]
        internal static byte crop4(byte x)
            => (byte)(U.MaxLiteral & x);

        static BitFormat FormatConfig4
            => BitFormatter.limited(U.Width, U.Width);

        [MethodImpl(Inline)]
        public static string format(U src)
            => BitFormatter.format(src.data, FormatConfig4);


        [MethodImpl(Inline), Op]
        public static U @false(U a, U b)
            => U.Min;

        [MethodImpl(Inline), Op]
        public static U @true(U a, U b)
            => U.Max;

        [MethodImpl(Inline), Op]
        public static U nand(U a, U b)
            => ~(a & b);

        [MethodImpl(Inline), Op]
        public static U nor(U a, U b)
            => ~(a | b);

        [MethodImpl(Inline), Op]
        public static U xnor(U a, U b)
            => ~(a ^ b);

        [MethodImpl(Inline), Op]
        public static U impl(U a, U b)
            => a | ~b;

        [MethodImpl(Inline), Op]
        public static U nonimpl(U a, U b)
            => ~a & b;

        [MethodImpl(Inline), Op]
        public static U left(U a, U b)
            => a;

        [MethodImpl(Inline), Op]
        public static U right(U a, U b)
            => b;

        [MethodImpl(Inline), Op]
        public static U lnot(U a, U b)
            => ~a;

        [MethodImpl(Inline), RNot]
        public static U rnot(U a, U b)
            => ~b;

        [MethodImpl(Inline), Op]
        public static U cimpl(U a, U b)
            => ~a | b;

        [MethodImpl(Inline), Op]
        public static U cnonimpl(U a, U b)
            => a & ~b;

        [MethodImpl(Inline)]
        public static U same(U a, U b)
            => @byte(a == b);

        [MethodImpl(Inline), Select]
        public static U select(U a, U b, U c)
            => or(and(a,b), nonimpl(a,c));
    }
}