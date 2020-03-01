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
    
    partial class ginx
    {
        /// <summary>
        /// Expands a bit-level S-pattern to a block-level T-pattern
        /// </summary>
        /// <param name="src">The source pattern</param>
        /// <param name="enabled">The value to assign to a block when the corresponding index-identified bit is enabled</param>
        /// <param name="dst">The target pattern receiver</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block128<T> broadcast<S,T>(S src, T enabled, in Block128<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            var length = math.min(dst.CellCount, bitsize<S>());
            for(var i=0; i< length; i++)
                dst[i] = gbits.testbit(src,i) ? enabled : default;
            return ref dst;
        }

        /// <summary>
        /// Expands a bit-level S-pattern to a block-level T-pattern
        /// </summary>
        /// <param name="src">The source pattern</param>
        /// <param name="enabled">The value to assign to a block when the corresponding index-identified bit is enabled</param>
        /// <param name="dst">The target pattern receiver</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block256<T> broadcast<S,T>(S src, T enabled, in Block256<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            var length = math.min(dst.CellCount, bitsize<S>());
            for(var i=0; i< length; i++)
                dst[i] = gbits.testbit(src,i) ? enabled : default;
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
        public static T broadcast<S,T>(S src, T t = default)
            where S : unmanaged
            where T : unmanaged
                => vfuncs.vfirst<S,T>(CpuVector.vbroadcast(n128, src));                
    }
}