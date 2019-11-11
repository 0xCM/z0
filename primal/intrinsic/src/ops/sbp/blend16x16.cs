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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
        
    using static zfunc;
    
    partial class dinx
    {

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vblend16x16(Vector256<short> x, Vector256<short> y, Vector256<short> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vblend16x16(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> spec)        
            => BlendVariable(x, y, spec);



    }

}