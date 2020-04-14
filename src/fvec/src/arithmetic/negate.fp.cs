//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class dinxfp
    {
        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vnegate(Vector128<float> x)
            =>  vsub(default, x);

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vnegate(Vector128<double> x)
            =>  vsub(default, x);

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vnegate(Vector256<float> x)
            =>  vsub(default, x);

        /// <summary>
        /// Negates each source vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vnegate(Vector256<double> x)
            =>  vsub(default, x);
    }
}