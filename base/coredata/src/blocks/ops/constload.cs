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
        /// Loads a blocked readonly span from an unblocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock64<T> constload<T>(N64 n,  ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(n,src.Length - offset))
                badsize(n, src.Length - offset);      

            return new ConstBlock64<T>(offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads a blocked readonly span from an unblocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock128<T> constload<T>(N128 n, ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(n,src.Length - offset))
                badsize(n, src.Length - offset);      

            return new ConstBlock128<T>(offset == 0 ? src : src.Slice(offset));
        }

        [MethodImpl(Inline)]
        public static ConstBlock128<T> constload<T>(N128 n, ReadOnlySpan<T> src, int offset, int length)
            where T : unmanaged
        {
            if(!aligned<T>(n,src.Length - offset))
                badsize(n, src.Length - offset);      

            return new ConstBlock128<T>(src.Slice(offset, length));
        }

    }

}