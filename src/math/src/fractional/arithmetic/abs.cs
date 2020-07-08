//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static core;
    
    partial class fmath
    {
        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Abs]
        public static float abs(float a)
        {
            var b =  new F32Bits(a);
            b.Bits &= F32Bits.SignMask;
            return b.Data;
        }

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Abs]
        public static double abs(double a)
        {
            var b = new F64Bits(a);
            b.Bits &= F64Bits.SignMask;
            return b.Data;
        }
    }
}