//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;    
    using static gvec;
    
    partial class ginx
    {        
        /// <summary>
        /// Rotates the full 128 bits of a vector leftward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to shift</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vrotlx<T>(Vector128<T> src, [Shift] byte count)        
            where T : unmanaged
                => generic<T>(dinx.vrotlx(v64u(src), count));

        /// <summary>
        /// Rotates each 128 bit lane vector leftward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to shift</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vrotlx<T>(Vector256<T> src, [Shift] byte count)        
            where T : unmanaged
                => generic<T>(dinx.vrotlx(v64u(src), count));
    }
}