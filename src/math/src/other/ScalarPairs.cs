//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Konst;
    using static refs;

    [ApiHost]
    public class ScalarPairs : IApiHost<ScalarPairs>
    {       
        /// <summary>
        /// Zero, the the one and only.
        /// </summary>
        public static ConstPair<ulong> Zero => default;

        /// <summary>
        /// One, just.
        /// </summary>
        public static ConstPair<ulong> One => (1,0);

        /// <summary>
        /// One, so many
        /// </summary>
        public static ConstPair<ulong> Ones => (ulong.MaxValue, ulong.MaxValue);

        /// <summary>
        /// Computes the bitwise complement of a 128-bit integer
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> not(in ConstPair<ulong> x)
            => (~x.Left, ~x.Right);

        /// <summary>
        /// Computes the bitwise AND of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> and(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => (x.Left & y.Left, x.Right & y.Right);

        /// <summary>
        /// Computes the bitwise NAND of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> nand(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => not(and(x,y));

        /// <summary>
        /// Computes the bitwise OR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> or(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => (x.Left | y.Left, x.Right | y.Right);

        /// <summary>
        /// Computes the bitwise NOR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> nor(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => not(or(x,y));

        /// <summary>
        /// Computes the bitwise XOR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> xor(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => (x.Left ^ y.Left, x.Right ^ y.Right);

        /// <summary>
        /// Computes the bitwise XNOR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> xnor(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => not(xor(x,y));

        /// <summary>
        /// Determines whether the left and right operands define the same value
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static bit same(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => x.Left == y.Left && x.Right == y.Right;

        /// <summary>
        /// Determines whether the left operand is less than the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static bit lt(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => x.Right < y.Right | ((x.Right == y.Right) && (x.Left < y.Left));

        /// <summary>
        /// Determines whether the left operand is less than or equal the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static bit lteq(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => x.Right < y.Right | ((x.Right == y.Right) && (x.Left <= y.Left));

        /// <summary>
        /// Determines whether the left operand is greater than the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static bit gt(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => !lteq(x,y);

        /// <summary>
        /// Determines whether the left operand is greater than or equal the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static bit gteq(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => !lt(x,y);

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
            bit carry = x.Left > lo;
            var hi = x.Right + y.Right + (uint)carry;
            return (lo,hi);
        }

        /// <summary>
        /// Computes the sum c := a + b of 128-bit unsigned integers a and b
        /// </summary>
        /// <param name="a">A reference to the left 128-bits</param>
        /// <param name="b">A reference to the right 128-bits</param>
        /// <param name="c">A reference to the target 128-bits</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static void add(in ulong a, in ulong b, ref ulong c)
        {
            c = a + b;
            bit carry = a > c;
            seek(ref c, 1) = skip(in a, 1) + skip(in b, 1) + (uint)carry;
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
            bit borrow = x.Left < lo;
            var hi = x.Right - y.Right - (uint)borrow;
            return (lo,hi);
        }

        /// <summary>
        /// Computes the difference c := a - b between 128-bit unsigned integers a and b
        /// </summary>
        /// <param name="a">A reference to the left 128-bits</param>
        /// <param name="b">A reference to the right 128-bits</param>
        /// <param name="c">A reference to the target 128-bits</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static void sub(in ulong a, in ulong b, ref ulong c)
        {
            c = a - b;
            bit borrow = a < c;
            seek(ref c, 1) = skip(in a, 1) - skip(in b, 1) - (uint)borrow;
        }

        /// <summary>
        /// Computes the two's complement of a 128-bit integer
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> negate(ConstPair<ulong> x)
            => add(not(x), One);

        [MethodImpl(Inline), Op]
        public static ref ConstPair<ulong> dec(ref ConstPair<ulong> x)
        {
            x = sub(x, One);
            return ref x;
        }

        [MethodImpl(Inline), Op]
        public static ref ConstPair<ulong> inc(ref ConstPair<ulong> x)
        {
            x = add(x, One);
            return ref x;
        }

        [MethodImpl(Inline), Op]
        public static ref ulong inc(ref ulong x)
        {
            var o = One;
            add(in x, in o.Left, ref x);
            return ref x;
        }

        [MethodImpl(Inline), Op]
        public static void inc(in ulong x, ref ulong y)
        {
            var o = One;
            add(in x, in o.Left, ref y);
        }

        [MethodImpl(Inline), Op]
        public static ref ulong dec(ref ulong x)
        {
            var o = One;
            sub(in x, in o.Left, ref x);
            return ref x;
        }

        [MethodImpl(Inline), Op]
        public static void dec(in ulong x, ref ulong y)
        {
            var o = One;
            sub(in x, in o.Left, ref y);
        }

        /// <summary>
        /// Shifts the source integer leftwards
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        /// <param name="offset">The number of bits to shift letward</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> sll(in ConstPair<ulong> x, byte offset)
            => offset < 64 
              ?  ((x.Right << offset) | ((x.Left >> 1) >> 63 - offset), x.Left << offset) 
              : offset < 128 
              ? (x.Left << (offset - 64),0) 
              : Zero;

        /// <summary>
        /// Shifts the source integer leftwards
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        /// <param name="offset">The number of bits to shift letward</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> srl(in ConstPair<ulong> x, byte offset)
            => offset < 64 
              ?  ((x.Right >> offset), (x.Left >> offset) | ((x.Right << 1) << 63 - offset))
              : offset < 128 
              ? (0, x.Left >> (offset - 64)) 
              : Zero;


        [MethodImpl(Inline), Op]
        public static unsafe ulong mullo(ulong x, ulong y)
        {
            var lo = 0ul;            
            Bmi2.X64.MultiplyNoFlags(x,y, &lo);
            return lo;
        }

        [MethodImpl(Inline), Op]
        public static ulong mulhi(ulong x, ulong y)
            => Bmi2.X64.MultiplyNoFlags(x,y);

        [MethodImpl(Inline), Op]
        public static unsafe void mul(ulong x, ulong y, out ulong lo, out ulong hi)
        {
           lo = 0ul;
           hi = Bmi2.X64.MultiplyNoFlags(x,y, Root.ptr(ref lo));
        }

        [MethodImpl(Inline), Op]
        public static unsafe ref Pair<ulong> mul(in ConstPair<ulong> src, ref Pair<ulong> dst)  
        {               
            dst.Right = Bmi2.X64.MultiplyNoFlags(src.Left, src.Right, Root.ptr(ref dst.Left));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Pair<ulong> mul(ulong x, ulong y, out Pair<ulong> dst)                 
        {
            mul(x,y, out dst.Left, out dst.Right);
            return ref dst;
        }

        /// <summary>
        /// 64x64 -> 128 multiplication, reference implementation
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>
        /// Taken from https://github.com/chfast/intx/blob/master/include/intx/int128.hpp
        /// </returns>
        [MethodImpl(Inline), Op]
        static Pair<ulong> mul_ref(ulong x, ulong y)
        {
            var xl = x & 0xffffffffu;
            var xh = x >> 32;
            var yl = y & 0xffffffffu;
            var yh = y >> 32;

            var t0 = xl * yl;
            var t1 = xh * yl;
            var t2 = xl * yh;
            var t3 = xh * yh;

            var u1 = t1 + (t0 >> 32);
            var u2 = t2 + (u1 & 0xffffffffu);

            var lo = (u2 << 32) | (t0 & 0xffffffffu);
            var hi = t3 + (u2 >> 32) + (u1 >> 32);  
            return (lo,hi);          
        }

        /// <summary>
        /// Computes the lo part of the full 128-bit product of two unsigned 64-bit integers
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        [MethodImpl(Inline), Op]
        static ulong lo_ref(ulong x, ulong y)
            => x*y;

        [MethodImpl(Inline), Op]
        public static unsafe uint mullo(uint x, uint y)
        {
            var lo = 0u;
            Bmi2.MultiplyNoFlags(x,y, Root.ptr(ref lo));
            return lo;
        }

        [MethodImpl(Inline), Op]
        public static ulong mulhi(uint x, uint y)
            => Bmi2.MultiplyNoFlags(x,y);

        [MethodImpl(Inline), Op]
        public static unsafe void mul(uint x, uint y, out uint lo, out uint hi)
        {
           lo = 0u;
           hi = Bmi2.MultiplyNoFlags(x,y, Root.ptr(ref lo));
        }

        /// <summary>
        /// Computes the unsigned 64-bit product of two unsigned 32-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong mul(uint x, uint y)
        {
            var dst = 0u;
            return (((ulong)Bmi2.MultiplyNoFlags(x, y, Root.ptr(ref dst))) << 32) | dst;
        }
            
        [MethodImpl(Inline), Op]
        public static ref Pair<uint> mul(uint x, uint y, out Pair<uint> dst)                 
        {
            mul(x,y, out dst.Left, out dst.Right);
            return ref dst;
        }
            
        [MethodImpl(Inline), Op]
        public static unsafe ref Pair<uint> mul(in ConstPair<uint> src, ref Pair<uint> dst)                 
        {
            dst.Right = Bmi2.MultiplyNoFlags(src.Left, src.Right, Root.ptr(ref dst.Left));
            return ref dst;
        }


        /// <summary>
        /// Add src to the 128 bits contained in dst. Ignores overflow, that is, the addition is done modulo 2^128.
        /// </summary>
        /// <remarks>Taken from IntUtils.cs / Microsoft Machine Learning repository</remarks>
        [MethodImpl(Inline), Op]
        static void add(ref ulong dstHi, ref ulong dstLo, ulong src)
        {
            if ((dstLo += src) < src)
                dstHi++;
        }

        /// <summary>
        /// Add src to dst. Ignores overflow, that is, the addition is done modulo 2^128.
        /// </summary>
        /// <remarks>Taken from IntUtils.cs / Microsoft Machine Learning repository</remarks>
        [MethodImpl(Inline), Op]
        static void add(ref ulong dstHi, ref ulong dstLo, ulong srcHi, ulong srcLo)
        {
            if ((dstLo += srcLo) < srcLo)
                dstHi++;
            dstHi += srcHi;
        }

        /// <summary>
        /// Subtract src from the 128 bits contained in dst. Ignores overflow, that is, the subtraction is
        /// done modulo 2^128.
        /// </summary>
        /// <remarks>Taken from IntUtils.cs / Microsoft Machine Learning repository</remarks>
        [MethodImpl(Inline), Op]
        static void sub(ref ulong dstHi, ref ulong dstLo, ulong src)
        {
            if (dstLo < src)
                dstHi--;
            dstLo -= src;
        }

        /// <summary>
        /// Subtract src from dst. Ignores overflow, that is, the subtraction is done modulo 2^128.
        /// </summary>
        /// <remarks>Taken from IntUtils.cs / Microsoft Machine Learning repository</remarks>
        [MethodImpl(Inline), Op]
        static void sub(ulong srcLo, ulong srcHi, ref ulong dstLo, ref ulong dstHi)
        {
            dstHi -= srcHi;
            if (dstLo < srcLo)
                dstHi--;
            dstLo -= srcLo;
        }
    }
}