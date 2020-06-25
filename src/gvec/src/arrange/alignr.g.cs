//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Konst;
    using static As;
    
    partial class gvec
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="offset">The rightward shift amount, in bytes</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector128<T> valignr<T>(Vector128<T> x, Vector128<T> y, [Imm] byte offset)        
            where T : unmanaged
                => generic<T>(dvec.valignr(v64u(x), v64u(y), offset));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="offset">The rightward shift amount, in bytes</param>
        [MethodImpl(Inline), Op, Closures(NumericKind.All)]
        public static Vector256<T> valignr<T>(Vector256<T> x, Vector256<T> y, [Imm] byte offset)        
            where T : unmanaged
                => generic<T>(dvec.valignr(v64u(x), v64u(y), offset));
    }
}