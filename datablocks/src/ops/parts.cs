//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static Root;

    partial class blocks
    {
        /// <summary>
        /// Creates 16-bit blocked container from a parameter array and raises an error if the data source is not block-aligned
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> parts<T>(N16 w, params T[] src)
            where T : unmanaged        
        {
            if(!aligned<T>(w,src.Length))
                errors.ThrowBadSize(w, src.Length);      
            
            return new Block16<T>(src);
        }

        /// <summary>
        /// Creates 32-bit blocked span from a parameter array and raises an error if the data source is not block-aligned
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> parts<T>(N32 w, params T[] src)
            where T : unmanaged        
        {
            if(!aligned<T>(w,src.Length))
                errors.ThrowBadSize(w, src.Length);      
            
            return new Block32<T>(src);
        }

        /// <summary>
        /// Creates 64-bit blocked span from a parameter array and raises an error if the data source is not block-aligned
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> parts<T>(N64 w, params T[] src)
            where T : unmanaged        
        {
            if(!aligned<T>(w,src.Length))
                errors.ThrowBadSize(w, src.Length);      
            
            return new Block64<T>(src);
        }

        /// <summary>
        /// Creates 128-bit blocked span from a parameter array and raises an error if the data source is improperly blocked
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> parts<T>(N128 w, params T[] src)
            where T : unmanaged        
        {
            if(!aligned<T>(w,src.Length))
                errors.ThrowBadSize(w, src.Length);      
            
            return new Block128<T>(src);
        }

        /// <summary>
        /// Creates 256-bit blocked span from a parameter array and raises an error if the data source is improperly blocked
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> parts<T>(N256 w, params T[] src)
            where T : unmanaged        
        {
            if(!aligned<T>(w,src.Length))
                errors.ThrowBadSize(w, src.Length);    

            return new Block256<T>(src);
        }

        /// <summary>
        /// Creates 512-bit blocked span from a parameter array and raises an error if the data source is improperly blocked
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> parts<T>(N512 w, params T[] src)
            where T : unmanaged        
        {
            if(!aligned<T>(w,src.Length))
                errors.ThrowBadSize(w, src.Length);    

            return new Block512<T>(src);
        }

    }
}