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
    
    using static zfunc;    
    
    partial class ginxs
    {
        /// <summary>
        /// Broadcasts an S-cell over a T-cell
        /// </summary>
        /// <param name="src">The source cell value</param>
        /// <param name="dst">The target cell</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T broadcast<S,T>(S src, out T dst)
            where S : unmanaged
            where T : unmanaged
        {
            dst = vhead<S,T>(ginx.vbroadcast(n128, src));
            return ref dst;
        }

        /// <summary>
        /// Broadcasts an S-cell over a T-cell
        /// </summary>
        /// <param name="src">The source cell value</param>
        /// <param name="dst">The target cell</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static T broadcast<S,T>(S src)
            where S : unmanaged
            where T : unmanaged
                => vhead<S,T>(ginx.vbroadcast(n128, src));       
    }
}