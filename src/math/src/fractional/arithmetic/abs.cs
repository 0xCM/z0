//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class fmath
    {
        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Abs]
        public static float abs(float a)
        {
            var b =  new BitsF32(a);
            b.Bits &= BitsF32.SignMask;
            return b.Data;
        }

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline), Abs]
        public static double abs(double a)
        {
            var b = new BitsF64(a);
            b.Bits &= BitsF64.SignMask;
            return b.Data;
        }
    }
}