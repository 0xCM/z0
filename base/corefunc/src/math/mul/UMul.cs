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


    /// <summary>
    /// Defines operations for computing full 64-bit and 128-products of unsigned integers
    /// </summary>
    public static unsafe class UMul
    {
        [MethodImpl(Inline)]
        public static (ulong lo, ulong hi)  mul(ulong lhs, ulong rhs)
        {
            var lo = 0ul;
            var hi = Bmi2.X64.MultiplyNoFlags(lhs,rhs, refptr(ref lo));
            return (lo,hi);
        }

        /// <summary>
        /// Computes the 128-bit product of two 64-bit unsigned integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The 128 bit result</param>
        [MethodImpl(Inline)]
        public static void mul(ulong lhs, ulong rhs, out ulong lo, out ulong hi)
        {
            lo = 0;
            hi = Bmi2.X64.MultiplyNoFlags(lhs,rhs, refptr(ref lo));
        }

        /// <summary>
        /// Computes the unsigned 64-bit product of two unsigned 32-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong mul(uint lhs, uint rhs)
        {
            var dst = 0u;
            return (((ulong)Bmi2.MultiplyNoFlags(lhs, rhs, refptr(ref dst))) << 32) | dst;
        }

        /// <summary>
        /// Calculates the 128-bit product of two 64-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The 128 bit result</param>
        [MethodImpl(Inline)]
        public static unsafe ref UInt128 mul(ulong lhs, ulong rhs, out UInt128 dst)
        {
            dst = 0;
            mul(lhs,rhs, out dst.lo, out dst.hi);
            return ref dst;
        }

        /// <summary>
        /// Effects multiplication of the form (lhs:ulong, rhs:ulong) -> result:ulong where
        /// the result is obtained from the hi 64 bits of the 128-bit product
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong himul(ulong lhs, ulong rhs)
        {
            UMul.himul(lhs,rhs, out ulong hi);
            return hi;
        }

        [MethodImpl(Inline)]
        public static ulong lomul(ulong lhs, ulong rhs)
        {
            UMul.lomul(lhs,rhs, out ulong lo);
            return lo;
        }

        /// <summary>
        /// Computes the hi part of the 64-bit product of two unsigned 64-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline)]
        public static void himul(ulong lhs, ulong rhs, out ulong dst)
            => mul(lhs, rhs, out ulong lo, out dst);

        /// <summary>
        /// Computes the lo part of the 64-bit product of two unsigned 64-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The receiver</param>
        [MethodImpl(Inline)]
        public static void lomul(ulong lhs, ulong rhs, out ulong dst)
            => mul(lhs,rhs, out dst, out ulong hi);

        /// <summary>
        /// Add src to the 128 bits contained in dst. Ignores overflow, that is, the addition is done modulo 2^128.
        /// </summary>
        /// <remarks>Taken from IntUtils.cs / Microsoft Machine Learning repository</remarks>
        [MethodImpl(Inline)]
        public static void add(ref ulong dstHi, ref ulong dstLo, ulong src)
        {
            if ((dstLo += src) < src)
                dstHi++;
        }

        /// <summary>
        /// Add src to dst. Ignores overflow, that is, the addition is done modulo 2^128.
        /// </summary>
        /// <remarks>Taken from IntUtils.cs / Microsoft Machine Learning repository</remarks>
        [MethodImpl(Inline)]
        public static void add(ref ulong dstHi, ref ulong dstLo, ulong srcHi, ulong srcLo)
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
        public static void sub(ref ulong dstHi, ref ulong dstLo, ulong src)
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
        public static void sub(ref ulong dstHi, ref ulong dstLo, ulong srcHi, ulong srcLo)
        {
            dstHi -= srcHi;
            if (dstLo < srcLo)
                dstHi--;
            dstLo -= srcLo;
        }

        /// <summary>
        /// 64x64 -> 128 multiplication
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>
        /// Taken from https://github.com/chfast/intx/blob/master/include/intx/int128.hpp
        /// </returns>
        [MethodImpl(Inline)]
        public static Pair<ulong> mul128(ulong x, ulong y)
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
            return Pair.Define(lo,hi);          
        }
    }
}