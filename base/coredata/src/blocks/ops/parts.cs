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
        /// Creates 64-bit blocked span from a parameter array and raises an error if the data source is not block-aligned
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> parts<T>(N32 n, params T[] src)
            where T : unmanaged        
        {
            if(!aligned<T>(n,src.Length))
                badsize(n, src.Length);      
            return new Block32<T>(src);
        }

        /// <summary>
        /// Creates 64-bit blocked span from a parameter array and raises an error if the data source is not block-aligned
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> parts<T>(N64 n, params T[] src)
            where T : unmanaged        
        {
            if(!aligned<T>(n,src.Length))
                badsize(n, src.Length);      
            return new Block64<T>(src);
        }

        /// <summary>
        /// Creates 128-bit blocked span from a parameter array and raises an error if the data source is improperly blocked
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> parts<T>(N128 n, params T[] src)
            where T : unmanaged        
        {
            if(!aligned<T>(n,src.Length))
                badsize(n, src.Length);      
            
            Span<T> dst = src;
            return new Block128<T>(dst);
        }

        /// <summary>
        /// Creates 256-bit blocked span from a parameter array and raises an error if the data source is improperly blocked
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> parts<T>(N256 n, params T[] src)
            where T : unmanaged        
        {
            if(!aligned<T>(n,src.Length))
                badsize(n, src.Length);    

            return new Block256<T>(src);
        }
    }
}