//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// Shifts the full 128 bits of a vector rightward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vsrlx<T>(Vector128<T> src, byte offset)        
            where T : unmanaged
                => generic<T>(dinx.vsrlx(v64u(src), offset));

        /// <summary>
        /// Shifts each 128 bit lane rightward at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vsrlx<T>(Vector256<T> src, byte offset)        
            where T : unmanaged
                => generic<T>(dinx.vsrlx(v64u(src), offset));
    }
}