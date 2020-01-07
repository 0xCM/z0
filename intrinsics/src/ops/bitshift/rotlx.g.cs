//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class ginx
    {        
        /// <summary>
        /// Rotates the full 128 bits of a vector leftward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInt)]
        public static Vector128<T> vrotlx<T>(Vector128<T> src, byte offset)        
            where T : unmanaged
                => vgeneric<T>(dinx.vrotlx(v64u(src), offset));

        /// <summary>
        /// Rotates each 128 bit lane vector leftward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInt)]
        public static Vector256<T> vrotlx<T>(Vector256<T> src, byte offset)        
            where T : unmanaged
                => vgeneric<T>(dinx.vrotlx(v64u(src), offset));
    }
}