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

    using U = uint2;
    using W = W2;

    partial struct BitNumbers
    {
        [MethodImpl(Inline), Op]
        public static string format(U src)
            => BitFormatter.format(src.data, BitFormatter.limited(U.Width, U.Width));

        [MethodImpl(Inline), Op]
        public static void render(U src, uint offset, Span<char> dst)
            => render(src, 2, offset, dst);

        [MethodImpl(Inline), Op]
        public static void render(U src, Span<char> dst)
            => render(src, 2, 0, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref S edit<S>(in U src)
            where S : unmanaged
                => ref @as<U,S>(src);

        /// <summary>
        /// Promotes a <see cref='U'/> to a <see cref='Z0.uint3'/>, as indicated by the <see cref='W3'/> selector
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint3 extend(U src, W w)
            => wrap3(src.Content);

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='U3'/>, as indicated by the <see cref='W3'/> selector
        /// and shifts the result <see cref='N1'/> bit leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static uint3 extend(W3 w, N1 n, U src)
            => (uint3)src << 1;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='U4'/>, as indicated by the <see cref='W4'/> selector
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint4 extend(W4 w, U src)
            => src;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='U5'/>, as indicated by the <see cref='W5'/> selector
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint5 extend(W5 w, U src)
            => src;

        /// <summary>
        /// Promotes a <see cref='U2'/> to a <see cref='Z0.uint6'/>, as indicated by the <see cref='W6'/> selector
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint6 extend(W6 w, U src)
            => src;

        /// <summary>
        /// Reduces the source value to a width-identified integer via modular arithmetic
        /// </summary>
        /// <param name="src">The input value</param>
        /// <param name="w">The target bit-width</param>
        [MethodImpl(Inline), Op]
        public static U reduce(byte src, W w)
            => new U(src);

        /// <summary>
        /// (a,b) -> [bbaa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        [MethodImpl(Inline), Op]
        public static uint4 join(U a, U b)
            => (uint4)a | ((uint4)b << 2);

        /// <summary>
        /// (a,b) -> [bbaa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        /// <param name="c">Source bits 4-5</param>
        /// <param name="d">Source bits 6-7</param>
        [MethodImpl(Inline), Op]
        public static uint6 join(U a, U b, U c)
            => (uint6)a | ((uint6)b << 2) | ((uint6)c << 4);

        /// <summary>
        /// (a,b,c,d) -> [dd cc bb aa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        /// <param name="c">Source bits 4-5</param>
        /// <param name="d">Source bits 6-7</param>
        [MethodImpl(Inline), Op]
        public static uint8T join(U a, U b, U c, U d)
            => (uint8T)a | ((uint8T)b << 2) | ((uint8T)c << 4) | ((uint8T)d << 6);

        /// <summary>
        /// Reinterprets an input reference as a mutable <see cref='U'/> reference cell
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
        public static U dec(U x)
            => !x.IsMin ? new U(Bytes.sub(x.data, 1), false) : U.Max;

        [MethodImpl(Inline), Op]
        public static U inc(U x)
            => !x.IsMax ? new U(memory.add(x.data, 1), false) : U.Min;

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
        /// Converts an enum to a width-identified integer
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static U scalar<K>(in K src, W w)
            where K : unmanaged, Enum
                => new U(@as<K,byte>(src));

        [MethodImpl(Inline)]
        internal static U wrap(W w, int src)
            => new U((byte)src,false);

        /// <summary>
        /// Creates a 2-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, bool src)
            => wrap2(@byte(src));

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, byte src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, sbyte src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, ushort src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, short src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, int src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, uint src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, long src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, ulong src)
            => new U((byte)((byte)src & U.MaxLiteral));

        /// <summary>
        /// Creates a 2-bit unsigned integer from a 2-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, bit x0, bit x1 = default)
             => new U(((uint)x0 << 0) | ((uint)x1 << 1), true);

        [MethodImpl(Inline), Op]
        public static U uint2(bool src)
            => wrap2(@byte(src));

        /// <summary>
        /// Creates a 2-bit unsigned integer from the first two source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(byte src)
            => new U(src);

        /// <summary>
        /// Injects the source value directly into the width-identified target, bypassing bounds-checks
        /// </summary>
        /// <param name="src">The value to inject</param>
        /// <param name="w">The target bit-width</param>
        [MethodImpl(Inline)]
        public static U inject(byte src, W w)
            => new U(src, false);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the first least two source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(sbyte src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the first least two source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(ushort src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least two bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(short src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least two bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(int src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least two bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(uint src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least two bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(long src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least two bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(ulong src)
            => new U((byte)((byte)src & U.MaxLiteral));

        [MethodImpl(Inline), Op]
        public static U add(U x, U y)
        {
            var sum = x.data + y.data;
            return wrap(w2, (sum >= U.Mod) ? sum - (byte)U.Mod: sum);
        }

        [MethodImpl(Inline), Op]
        public static U sub(U x, U y)
        {
            var diff = (int)x - (int)y;
            return wrap(w2, diff < 0 ? (byte)(diff + U.Mod) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static U mul(U a, U b)
            => reduce2((byte)(a.data * b.data));

        [MethodImpl(Inline), Op]
        public static U div (U a, U b)
            => wrap(w2, (byte)(a.data / b.data));

        [MethodImpl(Inline), Op]
        public static U mod (U a, U b)
            => wrap(w2, (byte)(a.data % b.data));

        [MethodImpl(Inline), Op]
        public static U srl(U a, byte b)
            => create(w2, a.data >> b);

        [MethodImpl(Inline), Op]
        public static U sll(U a, byte b)
            => create(w2, a.data << b);

        [MethodImpl(Inline), Op]
        public static bit test(U src, byte pos)
            => bit.test(src,pos);

        [MethodImpl(Inline), Op]
        public static U set(U src, byte pos, bit state)
        {
            if(pos < U.Width)
                return wrap(w2, bit.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline), Op]
        public static bool eq(U x, U y)
            => x.data == y.data;

        [MethodImpl(Inline), False]
        public static U @false(U a, U b)
            => U.Min;

        [MethodImpl(Inline), True]
        public static U @true(U a, U b)
            => U.Max;

        [MethodImpl(Inline), Op]
        public static U and(U a, U b)
            => wrap(w2, (byte)(a.data & b.data));

        [MethodImpl(Inline), Op]
        public static U or(U a, U b)
            => wrap(w2, (byte)(a.data | b.data));

        [MethodImpl(Inline), Op]
        public static U xor(U a, U b)
            => wrap(w2, (byte)(a.data ^ b.data));

        [MethodImpl(Inline), Op]
        public static U not(U a)
            => wrap2(~a.data & U.MaxLiteral);

        [MethodImpl(Inline), Nand]
        public static U nand(U a, U b)
            => ~(a & b);

        [MethodImpl(Inline), Nor]
        public static U nor(U a, U b)
            => ~(a | b);

        [MethodImpl(Inline), Xnor]
        public static U xnor(U a, U b)
            => ~(a ^ b);

        [MethodImpl(Inline), Impl]
        public static U impl(U a, U b)
            => a | ~b;

        [MethodImpl(Inline), NonImpl]
        public static U nonimpl(U a, U b)
            => ~a & b;

        [MethodImpl(Inline), Left]
        public static U left(U a, U b)
            => a;

        [MethodImpl(Inline), Right]
        public static U right(U a, U b)
            => b;

        [MethodImpl(Inline), LNot]
        public static U lnot(U a, U b)
            => ~a;

        [MethodImpl(Inline), RNot]
        public static U rnot(U a, U b)
            => ~b;

        [MethodImpl(Inline), CImpl]
        public static U cimpl(U a, U b)
            => ~a | b;

        [MethodImpl(Inline), CNonImpl]
        public static U cnonimpl(U a, U b)
            => a & ~b;

        [MethodImpl(Inline), Same]
        public static U same(U a, U b)
            => @byte(a == b);

        [MethodImpl(Inline), Select]
        public static U select(U a, U b, U c)
            => or(and(a,b), nonimpl(a,c));

        [MethodImpl(Inline), Op]
        public static Span<bit> bits(uint2 src)
        {
            var storage = 0ul;
            var dst = slice(@recover<byte,bit>(@bytes(storage)),0, U.BitCount);
            if(bit.test(src,0))
                seek(dst,0) = bit.On;
            if(bit.test(src,1))
                seek(dst,1) = bit.On;
            return dst;
        }

        [MethodImpl(Inline)]
        public static byte crop2(byte x)
            => (byte)(U.MaxLiteral & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce2(byte x)
            => (byte)(x % U.Mod);

        [MethodImpl(Inline)]
        internal static U wrap2(int src)
            => new U((byte)src, false);
    }
}