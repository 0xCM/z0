//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Rotates the full 128 bits of a vector rightward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bits">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vrotrx<T>(Vector128<T> src, byte bits)        
            where T : unmanaged
                => vgeneric<T>(dinx.vrotrx(v64u(src), bits));

        /// <summary>
        /// Rotates the each 128-bit lane rightward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bits">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vrotrx<T>(Vector256<T> src, byte bits)        
            where T : unmanaged
                => vgeneric<T>(dinx.vrotrx(v64u(src), bits));
    }
}