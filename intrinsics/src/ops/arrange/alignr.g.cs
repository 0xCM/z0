//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;    
    
    partial class ginx
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="offset">The rightward shift amount, in bytes</param>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.All)]
        public static Vector128<T> valignr<T>(Vector128<T> x, Vector128<T> y, [Imm] byte offset)        
            where T : unmanaged
                => vgeneric<T>(dinx.valignr(v64u(x), v64u(y),offset));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="offset">The rightward shift amount, in bytes</param>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.All)]
        public static Vector256<T> valignr<T>(Vector256<T> x, Vector256<T> y, [Imm] byte offset)        
            where T : unmanaged
                => vgeneric<T>(dinx.valignr(v64u(x), v64u(y),offset));
    }
}