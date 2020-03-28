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
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static Core;

    partial class dinxfp
    {
        /// <summary>
        /// Computes XOR(x,NOT(y)) for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vxornot(Vector128<float> x, Vector128<float> y)
            => Xor(x, vnot(y));

        /// <summary>
        /// Computes XOR(x,NOT(y)) for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vxornot(Vector128<double> x, Vector128<double> y)
            => Xor(x, vnot(y));

        /// <summary>
        /// Computes XOR(x,NOT(y)) for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vxornot(Vector256<float> x, Vector256<float> y)
            => Xor(x, vnot(y));

        /// <summary>
        /// Computes XOR(x,NOT(y)) for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vxornot(Vector256<double> x, Vector256<double> y)
            => Xor(x, vnot(y));


    }

}