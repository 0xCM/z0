//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Core;    
    using static VCore;
    
    partial class gvec
    {        
        /// <summary>
        /// Shifts the full 128 bits of a vector rightward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to shift</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vsrlx<T>(Vector128<T> src, [Imm] byte count)        
            where T : unmanaged
                => generic<T>(dvec.vsrlx(v64u(src), count));

        /// <summary>
        /// Shifts each 128 bit lane rightward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to shift</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vsrlx<T>(Vector256<T> src, [Imm] byte count)        
            where T : unmanaged
                => generic<T>(dvec.vsrlx(v64u(src), count));
    }
}