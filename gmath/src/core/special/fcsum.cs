//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class fmath
    {
        /// <summary>
        /// Impelements compensated floating-point summation
        /// </summary>
        /// <param name="src">The value to add to the total</param>
        /// <param name="delta">The last compensation amount</param>
        /// <param name="total">The running total</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Kahan_summation_algorithm</remarks>
        [MethodImpl(Inline)]
        public static ref double fcsum(in double src, ref double delta, ref double total)
        {
            var y = src - delta;
            var t = total + y;
            delta = (t - total) - y;
            total = t;
            return ref total;
        }
    }
}