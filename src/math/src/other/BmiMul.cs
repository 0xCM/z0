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

    using static Tuples;
    using static refs;


    partial class BmiMul
    {
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
           hi = Bmi2.X64.MultiplyNoFlags(x,y, ptr(ref lo));
        }
 
        [MethodImpl(Inline), Op]
        public static unsafe uint mullo(uint x, uint y)
        {
            var lo = 0u;
            Bmi2.MultiplyNoFlags(x,y, ptr(ref lo));
            return lo;
        }

        /// <summary>
        /// Computes the lo part of the full 128-bit product of two unsigned 64-bit integers
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        [MethodImpl(Inline), Op]
        public static ulong lo_ref(ulong x, ulong y)
            => x*y;

        [MethodImpl(Inline), Op]
        public static ulong mulhi(uint x, uint y)
            => Bmi2.MultiplyNoFlags(x,y);

        [MethodImpl(Inline), Op]
        public static unsafe void mul(uint x, uint y, out uint lo, out uint hi)
        {
           lo = 0u;
           hi = Bmi2.MultiplyNoFlags(x,y, ptr(ref lo));
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
            return (((ulong)Bmi2.MultiplyNoFlags(x, y, ptr(ref dst))) << 32) | dst;
        }            
    }
}