//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;
 
    using static zfunc;
    
    partial class Bits
    {                        
        /// <summary>
        /// Reurns a sequence of N enabled bits, starting from index 0 and extendint to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static ulong lomask<N>(N n = default)
            where N : unmanaged, ITypeNat
                => NatMath.pow2m1<N>();

        /// <summary>
        /// Enables a bit in the target identified its pow2 exponent
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ref ulong mask(ref ulong dst, int exp0)
        {
            dst |= (1ul << exp0);
            return ref dst;
        }

        /// <summary>
        /// Enables 2 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ref ulong mask(ref ulong dst, int exp0, int exp1)
        {
            mask(ref dst, exp0); 
            mask(ref dst, exp1);
            return ref dst;
        }

        /// <summary>
        /// Enables 3 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2)
        {
            mask(ref dst, exp0, exp1); 
            mask(ref dst, exp2);
            return ref dst;
        }


        /// <summary>
        /// Enables 4 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        /// <param name="exp3">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3)
        {
            mask(ref dst, exp0, exp1); 
            mask(ref dst, exp2, exp3);
            return ref dst;
        }

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
        public static ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4)
        {
            mask(ref dst, exp0, exp1, exp2, exp3); 
            mask(ref dst, exp4);
            return ref dst;
        }

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
        public static ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
        {
            mask(ref dst, exp0, exp1, exp2, exp3); 
            mask(ref dst, exp4, exp5);
            return ref dst;
        }

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
        public static ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
        {
            mask(ref dst, exp0, exp1, exp2, exp3); 
            mask(ref dst, exp4, exp5, exp6);
            return ref dst;
        }

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
        public static ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6, int exp7)
        {
            dst |= ((1ul << exp0) | (1ul << exp1) | (1ul << exp2) | (1ul << exp3) | (1ul << exp4) | (1ul << exp6) | (1ul << exp6) | (1ul << exp7));
            return ref dst;
        }

    }

}