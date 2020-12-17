//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct mtuples
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

        /// <summary>
        /// Computes the full 64-bit product between two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static unsafe void mul32x64(in Pair<uint> src, ref Pair<uint> dst)                 
            => dst.Right = MultiplyNoFlags(src.Left, src.Right, gptr(dst.Left));

        /// <summary>
        /// Computes the full 64-bit product between two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static Pair<uint> mul32x64(in Pair<uint> src)
        {                         
            var dst = default(Pair<uint>);
            mul32x64(src, ref dst);
            return dst;
        }

        /// <summary>
        /// Computes the full 128-bit product between two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static Pair<ulong> mul64x128(in Pair<ulong> src)
        {                         
            var dst = default(Pair<ulong>);
            mul64x128(src, ref dst);
            return dst;
        }

        /// <summary>
        /// Computes the full 128-bit product between two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static unsafe void mul64x128(in Pair<ulong> src, ref Pair<ulong> dst)                 
            => dst.Right = MultiplyNoFlags(src.Left, src.Right, gptr(dst.Left));

        /// <summary>
        /// Computes the full 128-bit product between two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="z">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static ref Pair<ulong> mul64x128(in ulong a, in ulong b, ref Pair<ulong> z)
        {                         
            mul64x128((a,b), ref z);
            return ref z;
        }

        /// <summary>
        /// Computes the full 128-bit products between corresponding 64-bit span elements
        /// </summary>
        /// <param name="xs">The left operands</param>
        /// <param name="xs">The right operands</param>
        /// <param name="zs">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static void mul64x128(ReadOnlySpan<ulong> xs, ReadOnlySpan<ulong> ys, Span<Pair<ulong>> zs)
        {
            var count = min(min(xs.Length, ys.Length), zs.Length);
            for(var i=0u; i<count; i++)
                mul64x128(skip(first(xs), i), skip(in first(ys), i), ref seek(first(zs), i));
        }

        /// <summary>
        /// Computes the full 128-bit products between 64-bit span elements and a 64-bit scalar
        /// </summary>
        /// <param name="xs">The left operands</param>
        /// <param name="xs">The scalar value</param>
        /// <param name="zs">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static void mul64x128(ReadOnlySpan<ulong> xs, ulong a, Span<Pair<ulong>> zs)
        {
            var count = xs.Length;
            for(var i=0u; i<count; i++)
                mul64x128(skip(first(xs), i), a, ref seek(first(zs), i));
        }
        
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
            x = sub(x, Tuples.@const(1ul,0ul));
            return ref x;
        }

        /// <summary>
        /// Computes the two's complement of a 128-bit integer
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> negate(ConstPair<ulong> x)
            => add(not(x), Tuples.@const(1ul,0ul));

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
            => not(mtuples.or(x,y));

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

        /// <summary>
        /// Computes the sum of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> add(in ConstPair<ulong> x, in ConstPair<ulong> y)
        {
            var lo = x.Left + y.Left;
            var carry = x.Left > lo;
            var hi = x.Right + y.Right + z.@uint(carry);
            return (lo,hi);
        }

        [MethodImpl(Inline), Op]
        public static ref ConstPair<ulong> inc(ref ConstPair<ulong> x)
        {
            x = add(x, Tuples.@const(1ul,0ul));
            return ref x;
        }

        /// <summary>
        /// Computes the difference of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> sub(in ConstPair<ulong> x, in ConstPair<ulong> y)
        {
            var lo = x.Left - y.Left;
            var borrow = x.Left < lo;
            var hi = x.Right - y.Right - z.@uint(borrow);
            return (lo,hi);
        }
   }
}