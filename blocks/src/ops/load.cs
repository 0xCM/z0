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

    partial class Blocks
    {
        /// <summary>
        /// Loads 16-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Width8 | NumericKind.Width16)]
        public static Block16<T> load<T>(N16 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                Errors.ThrowBadSize(w, src.Length - offset);      

            return unsafeload(w, offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads 32-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Width8 | NumericKind.Width16 | NumericKind.Width32)]
        public static Block32<T> load<T>(N32 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                Errors.ThrowBadSize(w, src.Length - offset);      

            return unsafeload(w, offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads 64-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Block64<T> load<T>(N64 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                Errors.ThrowBadSize(w, src.Length - offset);      

            return unsafeload(w, offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads 128-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Block128<T> load<T>(N128 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w, src.Length - offset))
                Errors.ThrowBadSize(w, src.Length - offset);      

            return unsafeload(w, offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads 256-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Block256<T> load<T>(N256 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                Errors.ThrowBadSize(w, src.Length - offset);      

            return unsafeload(w,offset == 0 ? src : src.Slice(offset));
        }

        /// <summary>
        /// Loads 256-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Block512<T> load<T>(N512 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                Errors.ThrowBadSize(w, src.Length - offset);      

            return unsafeload(w,offset == 0 ? src : src.Slice(offset));
        }
    }
}