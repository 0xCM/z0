//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend    
    {
        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block8<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);

        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <param name="length">The cell-relative slice length</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block8<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block16<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <param name="length">The cell-relative slice length</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block16<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block32<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <param name="length">The cell-relative slice length</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block32<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block64<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);

        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <param name="length">The cell-relative slice length</param>
        /// <typeparam name="T">The cell type</typeparam>            
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block64<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block128<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <param name="length">The cell-relative slice length</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block128<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block256<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <param name="length">The cell-relative slice length</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block256<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);             

        /// <summary>
        /// Slices a blocked data source at the cellular level
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The cell-relative offset at which to dice</param>
        /// <param name="length">The cell-relative slice length</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block512<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);
    }
}