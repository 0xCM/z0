//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;
    using static CellCalcs;

    partial struct SpanBlocks
    {
        /// <summary>
        /// Loads a specified count of 8-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe SpanBlock8<T> load<T>(W8 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock8<T>(cover(src, count*blocklength<T>(w)));

        /// <summary>
        /// Loads a specified count of 16-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe SpanBlock16<T> load<T>(W16 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock16<T>(cover(src, count*blocklength<T>(w)));

        /// <summary>
        /// Loads a specified count of 32-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe SpanBlock32<T> load<T>(W32 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock32<T>(cover(src, count*blocklength<T>(w)));

        /// <summary>
        /// Loads a specified count of 64-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe SpanBlock64<T> load<T>(W64 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock64<T>(cover(src, count*blocklength<T>(w)));

        /// <summary>
        /// Loads a single 128-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe SpanBlock128<T> load<T>(W128 w, ref T src)
            where T : unmanaged
                => new SpanBlock128<T>(MemoryMarshal.CreateSpan(ref src, blocklength<T>(w)));

        /// <summary>
        /// Loads a specified count of 128-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe SpanBlock128<T> load<T>(W128 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock128<T>(cover(src, count*blocklength<T>(w)));

        /// <summary>
        /// Loads a single 256-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe SpanBlock256<T> load<T>(W256 w, ref T src)
            where T : unmanaged
                => new SpanBlock256<T>(new Span<T>(gptr(src), blocklength<T>(w)));

        /// <summary>
        /// Loads a specified count of 256-bit block sfrom a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe SpanBlock256<T> load<T>(W256 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock256<T>(cover(src, count*blocklength<T>(w)));

        /// <summary>
        /// Loads a single 512-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe SpanBlock512<T> load<T>(W512 w, ref T src)
            where T : unmanaged
                => new SpanBlock512<T>(new Span<T>(gptr(src), blocklength<T>(w)));

        /// <summary>
        /// Loads a specified count of 512-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe SpanBlock512<T> load<T>(W512 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock512<T>(cover(src, count*blocklength<T>(w)));



        /// <summary>
        /// Loads 8-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock8<T> load<T>(W8 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                AppErrors.ThrowBadSize(w, src.Length - offset);

            return unsafeload(w, offset == 0 ? src : slice(src,offset));
        }

        /// <summary>
        /// Loads 16-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock16<T> load<T>(W16 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                AppErrors.ThrowBadSize(w, src.Length - offset);

            return unsafeload(w, offset == 0 ? src : slice(src,offset));
        }

        /// <summary>
        /// Loads 32-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock32<T> load<T>(W32 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                AppErrors.ThrowBadSize(w, src.Length - offset);

            return unsafeload(w, offset == 0 ? src : slice(src,offset));
        }

        /// <summary>
        /// Loads 64-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock64<T> load<T>(W64 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                AppErrors.ThrowBadSize(w, src.Length - offset);

            return unsafeload(w, offset == 0 ? src : slice(src,offset));
        }

        /// <summary>
        /// Loads 128-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock128<T> load<T>(W128 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w, src.Length - offset))
                AppErrors.ThrowBadSize(w, src.Length - offset);

            return unsafeload(w, offset == 0 ? src : slice(src,offset));
        }

        /// <summary>
        /// Loads 256-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock256<T> load<T>(W256 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                AppErrors.ThrowBadSize(w, src.Length - offset);

            return unsafeload(w,offset == 0 ? src : slice(src,offset));
        }

        /// <summary>
        /// Loads 256-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock512<T> load<T>(W512 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                AppErrors.ThrowBadSize(w, src.Length - offset);

            return unsafeload(w,offset == 0 ? src : slice(src,offset));
        }
    }
}