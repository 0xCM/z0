//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using S = uint5;

    partial struct Sized
    {
        /// <summary>
        /// Creates a 5-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint5(bool src)
            => new S(z.bitstate(src));

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint5(byte src)
            => new S(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint5(sbyte src)
            => new S(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint5(ushort src)
            => new S(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint5(short src)
            => new S(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint5(int src)
            => new S(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint5(uint src)
            => new S(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint5(long src)
            => new S(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint5(ulong src)
            => new S((byte)((byte)src & S.MaxVal));

        /// <summary>
        /// Creates a 5-bit unsigned integer from a 5-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        /// <param name="x2">The term at index 2</param>
        /// <param name="x3">The term at index 3</param>
        /// <param name="x4">The term at index 4</param>
        [MethodImpl(Inline), Op]
        public static S uint5(BitState x0, BitState x1 = default, BitState x2 = default, BitState x3 = default, BitState x4 = default)
             => wrap5(Bytes.or(
                 Bytes.sll((byte)x0, 0),
                 Bytes.sll((byte)x1, 1),
                 Bytes.sll((byte)x2, 2),
                 Bytes.sll((byte)x3, 3),
                 Bytes.sll((byte)x4, 4)
                 ));

        [MethodImpl(Inline), Op]
        public static S add(S x, S y)
        {
            var d = (byte)(x.data + y.data);
            var result = Bytes.gteq(d, S.Count) ? Bytes.sub(d, S.Count) : d;
            return new S(result, true);
        }

        [MethodImpl(Inline), Op]
        public static S sub(S x, S y)
        {
            var delta = x.data - y.data;
            if(delta < 0)
                return wrap5((byte)(delta + S.Count));
            else
                return wrap5((byte)delta);
        }

        [MethodImpl(Inline), Op]
        public static S div (S lhs, S rhs)
            => wrap5((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static S mod (S lhs, S rhs)
            => wrap5((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static S mul(S lhs, S rhs)
            => reduce5((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static S or(S lhs, S rhs)
            => wrap5((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static S and(S lhs, S rhs)
            => wrap5((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static S xor(S lhs, S rhs)
            => wrap5((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static S srl(S lhs, byte rhs)
            => uint5(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static S sll(S lhs, byte rhs)
            => uint5(lhs.data << rhs);

        [MethodImpl(Inline), Op]
        public static BitState test(S src, byte pos)
            => z.test(src,pos);

        [MethodImpl(Inline), Op]
        public static S set(S src, byte pos, BitState state)
            => Bytes.lt(pos, S.Width) ? new S(z.set(src.data, pos, state), false) : src;

        [MethodImpl(Inline)]
        public static bool eq(S x, S y)
            => Bytes.eq(x.data, y.data);

        [MethodImpl(Inline)]
        internal static byte crop5(byte x)
            => (byte)(S.MaxVal & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce5(byte x)
            => reduce(S.N, x);

        [MethodImpl(Inline)]
        internal static S wrap5(uint src)
            => new S(src,false);

        [MethodImpl(Inline)]
        internal static S wrap5(int src)
            => new S((byte)src,false);

        static BitFormat FormatConfig5
            => BitFormatter.limited(S.Width,S.Width);

        [MethodImpl(Inline)]
        public static string format(S src)
            => BitFormatter.format(src.data, FormatConfig5);
    }
}