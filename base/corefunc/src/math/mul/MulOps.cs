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


    public static unsafe class MulOps
    {
        /// <summary>
        /// Computes the full 64-bit product of two unsigned 32-bit integers
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        [MethodImpl(Inline)]
        public static ulong full(uint a, uint b)
            => ((ulong)a) * ((ulong)b);

        /// <summary>
        /// Computes the full 64-bit product of two unsigned 32-bit integers
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        /// <param name="lo">The lo part of the product</param>
        /// <param name="hi">The hi part of the product</param>
        [MethodImpl(Inline)]
        public static void full(uint a, uint b, out uint lo, out uint hi)               
        {
            var z = full(a,b);
            lo = (uint)z;
            hi = (uint)(z >> 32);            
        }

        /// <summary>
        /// Computes the lo part of the  full 64-bit product of two unsigned 32-bit integers
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        [MethodImpl(Inline)]
        public static uint lo(uint a, uint b)
            => (uint)full(a,b);

        /// <summary>
        /// Computes the hi part of the  full 64-bit product of two unsigned 32-bit integers
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        [MethodImpl(Inline)]
        public static uint hi(uint a, uint b)        
            => (uint)(full(a,b) >> 32);

        /// <summary>
        /// Computes the lo part of the full 128-bit product of two unsigned 64-bit integers
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        [MethodImpl(Inline)]
        public static ulong lo(ulong x, ulong y)
            => x*y;

        /// <summary>
        /// Computes the hi part of the full 128-bit product of two unsigned 64-bit integers
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        [MethodImpl(Inline)]
        public static ulong hi(ulong x, ulong y)
            => BmiMul.hi(x,y);

        /// <summary>
        /// Computes the full 128-bit product of two unsigned 64-bit integers
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        [MethodImpl(Inline)]
        public static void full(ulong x, ulong y, out ulong lo, out ulong hi)
        {
            lo = MulOps.lo(x,y);
            hi = MulOps.hi(x,y);
        }                       
    }
}