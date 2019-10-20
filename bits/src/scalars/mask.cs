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
        /// Enables a pow-2 bit in the target
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">A power of 2 exponent value in the integral range [0,63] </param>
        [MethodImpl(Inline)]
        public static ref ulong mask(ref ulong dst, int exp0)
        {
            dst |= (1ul << exp0);
            return ref dst;
        }

        /// <summary>
        /// Enables 2 pow-2 bits in the target
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">A power of 2 exponent value in the integral range [0,63] </param>
        /// <param name="exp1">A power of 2 exponent value in the integral range [0,63] </param>
        [MethodImpl(Inline)]
        public static ref ulong mask(ref ulong dst, int exp0, int exp1)
        {
            dst |= ((1ul << exp0) | (1ul << exp1));
            return ref dst;
        }

        /// <summary>
        /// Enables 3 pow-2 bits in the target
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">A power of 2 exponent value in the integral range [0,63] </param>
        /// <param name="exp1">A power of 2 exponent value in the integral range [0,63] </param>
        /// <param name="exp2">A power of 2 exponent value in the integral range [0,63] </param>
        [MethodImpl(Inline)]
        public static ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2)
        {
            dst |= ((1ul << exp0) | (1ul << exp1) | (1ul << exp2));
            return ref dst;
        }

        /// <summary>
        /// Enables 3 pow-2 bits in the source
        /// </summary>
        /// <param name="src">The mask reference</param>
        /// <param name="exp0">A power of 2 exponent value in the integral range [0,63] </param>
        /// <param name="exp1">A power of 2 exponent value in the integral range [0,63] </param>
        /// <param name="exp2">A power of 2 exponent value in the integral range [0,63] </param>
        [MethodImpl(Inline)]
        public static ulong mask(ulong src, int exp0, int exp1, int exp2)
        {
            var dst = src | ((1ul << exp0) | (1ul << exp1) | (1ul << exp2));
            return dst;
        }

        /// <summary>
        /// Enables 4 pow-2 bits in the target
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">A power of 2 exponent value in the integral range [0,63] </param>
        /// <param name="exp1">A power of 2 exponent value in the integral range [0,63] </param>
        /// <param name="exp2">A power of 2 exponent value in the integral range [0,63] </param>
        /// <param name="exp3">A power of 2 exponent value in the integral range [0,63] </param>
        [MethodImpl(Inline)]
        public static ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3)
        {
            dst |= ((1ul << exp0) | (1ul << exp1) | (1ul << exp2) | (1ul << exp3));
            return ref dst;
        }



    }

}