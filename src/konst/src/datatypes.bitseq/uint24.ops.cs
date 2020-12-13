//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static uint24;

    using U = uint24;

    partial struct BitSeq
    {
        [MethodImpl(Inline), Op]
        public static U maxval(W24 w)
            => maxval<U>();

        /// <summary>
        /// Creates a 24-bit unsigned integer, equal to zero or one, according to whether the source is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint24(bool src)
            => new U(src);

        /// <summary>
        /// Creates a 24-bit unsigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint24(byte src)
            => new U(src);

        /// <summary>
        /// Creates a 24-bit unsigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint24(sbyte src)
            => new U(src);

        /// <summary>
        /// Creates a 24-bit unsigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint24(ushort src)
            => new U(src);

        /// <summary>
        /// Creates a 24-bit unsigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint24(short src)
            => new U(src);

        /// <summary>
        /// Creates a 24-bit unsigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint24(int src)
            => new U(src);

        /// <summary>
        /// Creates a 24-bit unsigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint24(uint src)
            => new U(src);

        /// <summary>
        /// Creates a 24-bit unsigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint24(long src)
            => new U(src);

        /// <summary>
        /// Creates a 24-bit unsigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint24(ulong src)
            => new U(src);

        [MethodImpl(Inline), Op]
        public static U uint24(uint6 a, uint6 b, uint6 c, uint6 d)
        {
            var dst = new U();
            update(a | (b << 6) | (c << 12) | (d << 18), ref dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref uint24 update(uint src, ref uint24 dst)
        {
            dst.Lo = (ushort)src;
            dst.Hi = (byte)(src >> 16);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static BitState test(U x, byte pos)
            => z.test(x.data, pos);

        [MethodImpl(Inline), Op]
        public static U set(U x, byte pos, BitState state)
            => new U(z.set(x.data, pos, state));

        [MethodImpl(Inline), Op]
        public static U add(U x, U y)
            => x + y;

        [MethodImpl(Inline), Op]
        public static U sub(U x, U y)
            => x - y;

        [MethodImpl(Inline), Op]
        public static U div (U x, U y)
            => x / y;

        [MethodImpl(Inline), Op]
        public static U mod (U x, U y)
            => x % y;

        [MethodImpl(Inline), Op]
        public static U mul(U x, U y)
            => x * y;

        [MethodImpl(Inline), Op]
        public static U or(U x, U y)
            => x | y;

        [MethodImpl(Inline), Op]
        public static U and(U x, U y)
            => x & y;

        [MethodImpl(Inline), Op]
        public static U xor(U x, U y)
            => x ^ y;

        [MethodImpl(Inline), Op]
        public static U srl(U x, byte count)
            => x >> count;

        [MethodImpl(Inline), Op]
        public static U sll(U x, byte count)
            => x << count;

        [MethodImpl(Inline), Op]
        public static ref U inc(in U x)
        {
            ref var y = ref z.edit(x);
            y.data++;

            if(y.data > Mask)
                y.data = 0;

            return ref y;
        }

        [MethodImpl(Inline), Op]
        public static ref U dec(in U x)
        {
            ref var y = ref z.edit(x);
            y.data--;

            if(y.data > Mask)
                y.data = Mask;

            return ref y;
        }

        [MethodImpl(Inline), Op]
        public static bool eq(U x, U y)
            => x.data == y.data;
    }
}