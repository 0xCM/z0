//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public class tmath
    {
        /// <summary>
        /// Zero, the the one and only.
        /// </summary>
        public static ConstPair<ulong> Zero
            => default;

        /// <summary>
        /// One, just.
        /// </summary>
        public static ConstPair<ulong> One
            => (1,0);

        /// <summary>
        /// One, so many
        /// </summary>
        public static ConstPair<ulong> Ones
            => (ulong.MaxValue, ulong.MaxValue);

        [MethodImpl(Inline), Op]
        public static ref ulong inc(ref ulong x)
        {
            var o = Tuples.@const(1ul,0ul);
            math.add(x, o.Left, ref x);
            return ref x;
        }

        [MethodImpl(Inline), Op]
        public static void inc(in ulong x, ref ulong y)
        {
            var o = Tuples.@const(1ul,0ul);
            math.add(x, o.Left, ref y);
        }

        [MethodImpl(Inline), Op]
        public static ref ulong dec(ref ulong x)
        {
            var o = Tuples.@const(1ul,0ul);
            math.sub(in x, in o.Left, ref x);
            return ref x;
        }

        [MethodImpl(Inline), Op]
        public static void dec(in ulong x, ref ulong y)
        {
            var o = Tuples.@const(1ul,0ul);
            math.sub(in x, in o.Left, ref y);
        }

        [MethodImpl(Inline), Op]
        public static ref ConstPair<ulong> dec(ref ConstPair<ulong> x)
        {
            x = math.sub(x, Tuples.@const(1ul,0ul));
            return ref x;
        }

        /// <summary>
        /// Computes the two's complement of a 128-bit integer
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> negate(ConstPair<ulong> x)
            => math.add(not(x), Tuples.@const(1ul,0ul));

        /// <summary>
        /// Determines whether the left and right operands define the same value
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static bool eq(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => x.Left == y.Left && x.Right == y.Right;

        /// <summary>
        /// Determines whether the left operand is less than the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static bool lt(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => x.Right < y.Right | ((x.Right == y.Right) && (x.Left < y.Left));

         /// <summary>
        /// Determines whether the left operand is less than or equal the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static bool lteq(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => x.Right < y.Right | ((x.Right == y.Right) && (x.Left <= y.Left));

        /// <summary>
        /// Determines whether the left operand is greater than or equal the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static bool gteq(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => !lt(x,y);

        /// <summary>
        /// Determines whether the left operand is greater than the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static bool gt(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => !lteq(x,y);
        /// <summary>
        /// Shifts the source integer leftwards
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        /// <param name="offset">The number of bits to shift letward</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> sll(in ConstPair<ulong> x, byte offset)
            => offset < 64
              ? Tuples.@const((x.Right << offset) | ((x.Left >> 1) >> 63 - offset), x.Left << offset)
              : offset < 128
              ? Tuples.@const(x.Left << (offset - 64), z64)
              : ConstPair.zero(z64);

       /// <summary>
        /// Shifts the source integer leftwards
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        /// <param name="offset">The number of bits to shift letward</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> srl(in ConstPair<ulong> x, byte offset)
            => offset < 64
              ?  Tuples.@const((x.Right >> offset), (x.Left >> offset) | ((x.Right << 1) << 63 - offset))
              : offset < 128
              ? Tuples.@const(z64, x.Left >> (offset - 64))
              : ConstPair.zero(z64);

        /// <summary>
        /// Computes the bitwise OR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> or(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => Tuples.@const(x.Left | y.Left, x.Right | y.Right);

        /// <summary>
        /// Computes the bitwise complement of a 128-bit integer
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> not(in ConstPair<ulong> x)
            => Tuples.@const(~x.Left, ~x.Right);

        /// <summary>
        /// Computes the bitwise XOR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> xor(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => Tuples.@const(x.Left ^ y.Left, x.Right ^ y.Right);

        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> nor(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => not(tmath.or(x,y));

        /// <summary>
        /// Computes the bitwise AND of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> and(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => Tuples.@const(x.Left & y.Left, x.Right & y.Right);

        /// <summary>
        /// Computes the bitwise NAND of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> nand(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => not(and(x,y));

        /// <summary>
        /// Computes the bitwise XNOR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> xnor(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => not(xor(x,y));
   }
}