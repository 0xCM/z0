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
    
    using static As;
    using static zfunc;

    partial class ginx
    {

        /// <summary>
        /// Shuffles 8-bit source segments according to the shuffle spec
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vshuf16x8<T>(Vector128<T> src, Vector128<byte> spec)
            where T : unmanaged
                => As.vgeneric<T>(dinx.vshuf16x8(v8u(src), spec));

        /// <summary>
        /// Shuffles 8-bit source segments within 128-bit lanes according to the shuffle spec
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vshuf16x8<T>(Vector256<T> src, Vector256<byte> spec)
            where T : unmanaged
                => vgeneric<T>(dinx.vshuf16x8(v8u(src), spec));
    }

}