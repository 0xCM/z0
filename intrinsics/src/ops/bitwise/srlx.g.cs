//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static As;
    
    partial class ginx
    {        
        /// <summary>
        /// Shifts the full 128 bits of a vector rightward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vsrlx<T>(Vector128<T> src, byte shift)        
            where T : unmanaged
                => vgeneric<T>(dinx.vsrlx(v64u(src), shift));

        /// <summary>
        /// Shifts each 128 bit lane rightward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vsrlx<T>(Vector256<T> src, byte shift)        
            where T : unmanaged
                => vgeneric<T>(dinx.vsrlx(v64u(src), shift));
    }
}