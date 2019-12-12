//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    partial class BitMask
    {        
        /// <summary>
        /// Enables a bit in the target identified its pow2 exponent
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong pow2(int exp0)
            => 1ul << exp0;

        /// <summary>
        /// Enables 2 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong pow2(int exp0, int exp1)
            => 1ul << exp0 | 1ul << exp1; 

        /// <summary>
        /// Enables 3 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong pow2(int exp0, int exp1, int exp2)
            => 1ul << exp0 | 1ul << exp1 | 1ul << exp2; 

        /// <summary>
        /// Enables 4 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        /// <param name="exp3">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong pow2(int exp0, int exp1, int exp2, int exp3)
            => 1ul << exp0 | 1ul << exp1 | 1ul << exp2 | 1ul << exp3; 

        /// <summary>
        /// Enables 5 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        /// <param name="exp3">An integer within the range [0,63]</param>
        /// <param name="exp4">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong pow2(int exp0, int exp1, int exp2, int exp3, int exp4)
            => 1ul << exp0 | 1ul << exp1 | 1ul << exp2 | 1ul << exp3 | 
               1ul << exp4;

        /// <summary>
        /// Enables 6 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        /// <param name="exp3">An integer within the range [0,63]</param>
        /// <param name="exp4">An integer within the range [0,63]</param>
        /// <param name="exp5">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong pow2(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
            => 1ul << exp0 | 1ul << exp1 | 1ul << exp2 | 1ul << exp3 | 
               1ul << exp4 | 1ul << exp5;

        /// <summary>
        /// Enables 7 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        /// <param name="exp3">An integer within the range [0,63]</param>
        /// <param name="exp4">An integer within the range [0,63]</param>
        /// <param name="exp5">An integer within the range [0,63]</param>
        /// <param name="exp6">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong pow2(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
            => 1ul << exp0 | 1ul << exp1 | 1ul << exp2 | 1ul << exp3 | 
               1ul << exp4 | 1ul << exp5 | 1ul << exp6;

        /// <summary>
        /// Enables 8 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        /// <param name="exp3">An integer within the range [0,63]</param>
        /// <param name="exp4">An integer within the range [0,63]</param>
        /// <param name="exp5">An integer within the range [0,63]</param>
        /// <param name="exp6">An integer within the range [0,63]</param>
        /// <param name="exp7">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong pow2(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6, int exp7)
            => 1ul << exp0 | 1ul << exp1 | 1ul << exp2 | 1ul << exp3 | 
               1ul << exp4 | 1ul << exp5 | 1ul << exp6 | 1ul << exp7; 
    }
}