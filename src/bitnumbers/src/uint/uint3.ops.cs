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

    using U = uint3;
    using W = W3;

    partial struct BitNumbers
    {
        [MethodImpl(Inline), Op]
        public static void render(U src, uint offset, Span<char> dst)
            => render(src, 3, offset, dst);

        [MethodImpl(Inline), Op]
        public static void render(U src, Span<char> dst)
            => render(src, 3, 0, dst);

        [MethodImpl(Inline), Op]
        public static U maxval(W w)
            => U.Max;

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
        /// (a:3, b:3, c:2) -> [cc bbb aaa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        /// <param name="c">Source bits 4-5</param>
        /// <param name="d">Source bits 6-7</param>
        [MethodImpl(Inline), Op]
        public static uint8T join(U a, U b, U c)
            => (uint8T)a | ((uint8T)b << 3) | ((uint8T)c << 6);

        [MethodImpl(Inline), Op]
        public static U inc(U x)
            => !x.IsMax ? new U(memory.add(x.data, 1), false) : U.Min;

        [MethodImpl(Inline), Op]
        public static U dec(U x)
            => !x.IsMin ? new U(Bytes.sub(x.data, 1), false) : U.Max;

        /// <summary>
        /// Reinterprets an input reference as a mutable <see cref='Z0.uint2'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref U edit<S>(in S src, W dst)
            where S : unmanaged
                => ref @as<S,U>(src);

        /// <summary>
        /// Converts a source integral value to an enum value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="K">The target enum  type</typeparam>
        [MethodImpl(Inline)]
        public static ref K refine<K>(in U src)
            where K : unmanaged, Enum
                => ref @as<U,K>(src);

        /// <summary>
        /// Converts an to sized integral value
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static U scalar<K>(in K src, W w)
            where K : unmanaged, Enum
                => new U(@as<K,byte>(src));

        /// <summary>
        /// Creates a 3-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(bool src)
            => wrap3(@byte(src));

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(byte src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(sbyte src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(ushort src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(short src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(int src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(uint src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(long src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(ulong src)
            => new U((byte)((byte)src & U.MaxLiteral));

        /// <summary>
        /// Creates a 3-bit unsigned integer from a 3-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        /// <param name="x2">The term at index 2</param>
        [MethodImpl(Inline), Op]
        public static U uint3(bit x0, bit x1 = default, bit x2 = default)
             => wrap3((byte)(
                 ((uint)x0 << 0) |
                 ((uint)x1 << 1) |
                 ((uint)x2 << 2)
                 ));

        [MethodImpl(Inline), Op]
        public static U add(U x, U y)
        {
            var sum = x.data + y.data;
            return wrap3((sum >= U.Mod) ? (byte)(sum - U.Mod): (byte)sum);
        }

        [MethodImpl(Inline), Op]
        public static U sub(U a, U b)
        {
            var diff = (int)a - (int)b;
            return wrap3(diff < 0 ? (byte)(diff + U.Mod) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static U mul(U lhs, U rhs)
            => reduce3((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static U div (U lhs, U rhs)
            => wrap3((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static U mod (U lhs, U rhs)
            => wrap3((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static U and(U lhs, U rhs)
            => wrap3((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static U or(U lhs, U rhs)
            => wrap3((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static U xor(U lhs, U rhs)
            => wrap3((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static U not(U a)
            => wrap3(~a.data & U.MaxLiteral);

        [MethodImpl(Inline), Op]
        public static U srl(U lhs, byte offset)
            => uint3(lhs.data >> offset);

        [MethodImpl(Inline), Op]
        public static U sll(U lhs, byte offset)
            => uint3(lhs.data << offset);

        [MethodImpl(Inline), Op]
        public static bit test(U src, byte pos)
            => bit.test(src, pos);

        [MethodImpl(Inline), Op]
        public static U set(U src, byte pos, bit state)
        {
            if(pos < U.Width)
                return wrap3(bit.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline), Op]
        public static bool eq(U x, U y)
            => x.data == y.data;

        /// <summary>
        /// Injects the source value directly into the width-identified target, bypassing bounds-checks
        /// </summary>
        /// <param name="src">The value to inject</param>
        /// <param name="w">The target bit-width</param>
        [MethodImpl(Inline)]
        public static U inject(byte src, W w)
            => new U(src, false);

        [MethodImpl(Inline), Op]
        public static Span<bit> bits(U src)
        {
            var storage = 0ul;
            var dst = slice(@recover<byte,bit>(@bytes(storage)),0, U.BitCount);
            if(bit.test(src,0))
                seek(dst,0) = bit.On;
            if(bit.test(src,1))
                seek(dst,1) = bit.On;
            if(bit.test(src,2))
                seek(dst,2) = bit.On;
            return dst;
        }

        [MethodImpl(Inline), Op]
        internal static byte reduce3(byte x)
            => (byte)(x % U.Mod);

        [MethodImpl(Inline)]
        internal static U wrap3(byte src)
            => new U(src, false);

        [MethodImpl(Inline)]
        internal static U wrap3(int src)
            => new U((byte)src,false);

        [MethodImpl(Inline)]
        public static byte crop3(byte x)
            => (byte)(U.MaxLiteral & x);

        static BitFormat FormatConfig3
            => BitFormatter.limited(U.Width, U.Width);

        [MethodImpl(Inline)]
        public static string format(U src)
            => BitFormatter.format(src.data, FormatConfig3);

        /// <summary>
        /// Promotes a triad to an quartet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint4 extend(U src, W4 w)
            => src;

        /// <summary>
        /// Promotes a triad to an quintet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint5 extend(U src, W5 w)
            => src;

        /// <summary>
        /// Promotes a triad to an quintet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint6 extend(U src, W6 w)
            => src;

        /// <summary>
        /// Promotes a triad to an octet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint8T extend(U src, W8 w)
            => src;
    }
}