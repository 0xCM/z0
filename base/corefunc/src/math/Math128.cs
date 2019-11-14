//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    public static class Math128
    {
        /// <summary>
        /// Zero, the the one and only.
        /// </summary>
        public static Pair<ulong> zero => default;

        /// <summary>
        /// One, just.
        /// </summary>
        public static Pair<ulong> one => (1,0);

        /// <summary>
        /// One, so many
        /// </summary>
        public static Pair<ulong> ones => (ulong.MaxValue, ulong.MaxValue);

        /// <summary>
        /// Computes the bitwise complement of a 128-bit integer
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline)]
        public static Pair<ulong> not(in Pair<ulong> x)
            => (~x.A, ~x.B);

        /// <summary>
        /// Computes the bitwise AND of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline)]
        public static Pair<ulong> and(in Pair<ulong> x, in Pair<ulong> y)
            => (x.A & y.A, x.B & y.B);

        /// <summary>
        /// Computes the bitwise NAND of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline)]
        public static Pair<ulong> nand(in Pair<ulong> x, in Pair<ulong> y)
            => not(and(x,y));

        /// <summary>
        /// Computes the bitwise OR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline)]
        public static Pair<ulong> or(in Pair<ulong> x, in Pair<ulong> y)
            => (x.A | y.A, x.B | y.B);

        /// <summary>
        /// Computes the bitwise NOR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline)]
        public static Pair<ulong> nor(in Pair<ulong> x, in Pair<ulong> y)
            => not(or(x,y));

        /// <summary>
        /// Computes the bitwise XOR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline)]
        public static Pair<ulong> xor(in Pair<ulong> x, in Pair<ulong> y)
            => (x.A ^ y.A, x.B ^ y.B);

        /// <summary>
        /// Computes the bitwise XNOR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline)]
        public static Pair<ulong> xnor(in Pair<ulong> x, in Pair<ulong> y)
            => not(xor(x,y));

        /// <summary>
        /// Determines whether the left and right operands define the same value
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline)]
        public static bit same(in Pair<ulong> x, in Pair<ulong> y)
            => x.A == y.A && x.B == y.B;

        /// <summary>
        /// Determines whether the left operand is less than the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline)]
        public static bit lt(in Pair<ulong> x, in Pair<ulong> y)
            => x.B < y.B | ((x.B == y.B) && (x.A < y.A));

        /// <summary>
        /// Determines whether the left operand is less than or equal the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline)]
        public static bit lteq(in Pair<ulong> x, in Pair<ulong> y)
            => x.B < y.B | ((x.B == y.B) && (x.A <= y.A));

        /// <summary>
        /// Determines whether the left operand is greater than the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline)]
        public static bit gt(in Pair<ulong> x, in Pair<ulong> y)
            => !lteq(x,y);

        /// <summary>
        /// Determines whether the left operand is greater than or equal the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline)]
        public static bit gteq(in Pair<ulong> x, in Pair<ulong> y)
            => !lt(x,y);

        /// <summary>
        /// Computes the sum of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline)]
        public static Pair<ulong> add(in Pair<ulong> x, in Pair<ulong> y)
        {
            var lo = x.A + y.A;
            bit carry = x.A > lo;
            var hi = x.B + y.B + (uint)carry;
            return (lo,hi);
        }

        /// <summary>
        /// Computes the difference of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline)]
        public static Pair<ulong> sub(in Pair<ulong> x, in Pair<ulong> y)
        {
            var lo = x.A - y.A;
            bit borrow = x.A < lo;
            var hi = x.B - y.B - (uint)borrow;
            return (lo,hi);
        }

        /// <summary>
        /// Computes the two's complement of a 128-bit integer
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline)]
        public static Pair<ulong> negate(Pair<ulong> x)
            => add(not(x), one);

        [MethodImpl(Inline)]
        public static ref Pair<ulong> dec(ref Pair<ulong> x)
        {
            x = sub(x,one);
            return ref x;
        }

        [MethodImpl(Inline)]
        public static ref Pair<ulong> inc(ref Pair<ulong> x)
        {
            x = add(x,one);
            return ref x;
        }

        /// <summary>
        /// Shifts the source integer leftwards
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        /// <param name="offset">The number of bits to shift letward</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline)]
        public static Pair<ulong> sll(in Pair<ulong> x, int offset)
            => offset < 64 
              ?  ((x.B << offset) | ((x.A >> 1) >> 63 - offset), x.A << offset) 
              : offset < 128 
              ? (x.A << (offset - 64),0) 
              : zero;

        /// <summary>
        /// Shifts the source integer leftwards
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        /// <param name="offset">The number of bits to shift letward</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline)]
        public static Pair<ulong> srl(in Pair<ulong> x, int offset)
            => offset < 64 
              ?  ((x.B >> offset), (x.A >> offset) | ((x.B << 1) << 63 - offset))
              : offset < 128 
              ? (0, x.A >> (offset - 64)) 
              : zero;

        [MethodImpl(Inline)]
        public static unsafe ulong mullo(ulong x, ulong y)
        {
            var lo = 0ul;            
            Bmi2.X64.MultiplyNoFlags(x,y, &lo);
            return lo;
        }

        [MethodImpl(Inline)]
        public static ulong mulhi(ulong x, ulong y)
            => Bmi2.X64.MultiplyNoFlags(x,y);

        [MethodImpl(Inline)]
        public static unsafe void mul(ulong x, ulong y, out ulong lo, out ulong hi)
        {
           lo = 0ul;
           hi = Bmi2.X64.MultiplyNoFlags(x,y, refptr(ref lo));
        }

        [MethodImpl(Inline)]
        public static unsafe ref Pair<ulong> mul(in Pair<ulong> src, ref Pair<ulong> dst)  
        {               
            dst.B = Bmi2.X64.MultiplyNoFlags(src.A, src.B, refptr(ref dst.A));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Pair<ulong> mul(ulong x, ulong y, out Pair<ulong> dst)                 
        {
            mul(x,y, out dst.A, out dst.B);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe uint mullo(uint x, uint y)
        {
            var lo = 0u;
            Bmi2.MultiplyNoFlags(x,y, refptr(ref lo));
            return lo;
        }

        [MethodImpl(Inline)]
        public static ulong mulhi(uint x, uint y)
            => Bmi2.MultiplyNoFlags(x,y);

        [MethodImpl(Inline)]
        public static unsafe void mul(uint x, uint y, out uint lo, out uint hi)
        {
           lo = 0u;
           hi = Bmi2.MultiplyNoFlags(x,y, refptr(ref lo));
        }

        /// <summary>
        /// Computes the unsigned 64-bit product of two unsigned 32-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static unsafe ulong mul(uint x, uint y)
        {
            var dst = 0u;
            return (((ulong)Bmi2.MultiplyNoFlags(x, y, refptr(ref dst))) << 32) | dst;
        }
            
        [MethodImpl(Inline)]
        public static ref Pair<uint> mul(uint x, uint y, out Pair<uint> dst)                 
        {
            mul(x,y, out dst.A, out dst.B);
            return ref dst;
        }
            
        [MethodImpl(Inline)]
        public static unsafe ref Pair<uint> mul(in Pair<uint> src, ref Pair<uint> dst)                 
        {
            dst.B = Bmi2.MultiplyNoFlags(src.A, src.B, refptr(ref dst.A));
            return ref dst;
        }

        /// <summary>
        /// Computes the lo part of the full 128-bit product of two unsigned 64-bit integers
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        [MethodImpl(Inline)]
        public static ulong lo_ref(ulong x, ulong y)
            => x*y;

        /// <summary>
        /// 64x64 -> 128 multiplication
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>
        /// Taken from https://github.com/chfast/intx/blob/master/include/intx/int128.hpp
        /// </returns>
        [MethodImpl(Inline)]
        public static Pair<ulong> full_ref(ulong x, ulong y)
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
            return Pair.define(lo,hi);          
        }

        /// <summary>
        /// Add src to the 128 bits contained in dst. Ignores overflow, that is, the addition is done modulo 2^128.
        /// </summary>
        /// <remarks>Taken from IntUtils.cs / Microsoft Machine Learning repository</remarks>
        [MethodImpl(Inline)]
        static void add(ref ulong dstHi, ref ulong dstLo, ulong src)
        {
            if ((dstLo += src) < src)
                dstHi++;
        }

        /// <summary>
        /// Add src to dst. Ignores overflow, that is, the addition is done modulo 2^128.
        /// </summary>
        /// <remarks>Taken from IntUtils.cs / Microsoft Machine Learning repository</remarks>
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        static void sub(ulong srcLo, ulong srcHi, ref ulong dstLo, ref ulong dstHi)
        {
            dstHi -= srcHi;
            if (dstLo < srcLo)
                dstHi--;
            dstLo -= srcLo;
        }
    }

}