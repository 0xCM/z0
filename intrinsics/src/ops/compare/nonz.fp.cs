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
    
    using static zfunc;    

    partial class dinxfp
    {
        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool vnonz(Vector128<float> src) 
            => ! TestZ(src, src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool vnonz(Vector128<double> src) 
            => ! TestZ(src, src);        
 
         /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool vnonz(Vector256<float> src) 
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool vnonz(Vector256<double> src) 
            => ! TestZ(src,src);
    }
}