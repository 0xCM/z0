//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class DataBlocks
    {
        /// <summary>
        /// Loads 64-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="n">The partition bit width</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> load<T>(N32 n, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(n,src.Length - offset))
                badsize(n, src.Length - offset);      
            return new Block32<T>(offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads 64-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="n">The partition bit width</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> load<T>(N64 n, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(n,src.Length - offset))
                badsize(n, src.Length - offset);      
            return new Block64<T>(offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads 128-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="n">The partition bit width</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> load<T>(N128 n, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(n, src.Length - offset))
                badsize(n, src.Length - offset);      
            return new Block128<T>(offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads 128-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="n">The partition bit width</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> load<T>(N256 n, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(n,src.Length - offset))
                badsize(n, src.Length - offset);      
            return new Block256<T>(offset == 0 ? src : src.Slice(offset));
        }
    }

}