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
    using static z;

    partial struct SpanBlocks
    {
        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static SpanBlock128<T> load<T>(Vector128<T> src)
            where T : unmanaged
        {
            var w = w128;
            var stack = Stacks.alloc(w);
            ref var dst = ref Stacks.head<T>(ref stack);
            z.vsave(src, ref dst);
            return SpanBlocks.load(w, ref dst);
        }

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static SpanBlock256<T> load<T>(Vector256<T> src)
            where T : unmanaged
        {
            var w = w256;
            var stack = Stacks.alloc(w);
            ref var dst = ref Stacks.head<T>(ref stack);
            z.vsave(src, ref dst);
            return SpanBlocks.load(w, ref dst);
        }

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static SpanBlock512<T> load<T>(Vector512<T> src)
            where T : unmanaged
        {
            var w = w512;
            var stack = Stacks.alloc(w);
            ref var dst = ref Stacks.head<T>(ref stack);
            z.vsave(src, ref dst);
            return SpanBlocks.load(w, ref dst);
        }

        /// <summary>
        /// Loads 8-bit segments from a span, raising an error if said source does not evenly partition
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static SpanBlock512<T> load<T>(W512 w, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(w,src.Length - offset))
                AppErrors.ThrowBadSize(w, src.Length - offset);

            return unsafeload(w,offset == 0 ? src : slice(src,offset));
        }
    }
}