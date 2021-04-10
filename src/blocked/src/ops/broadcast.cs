//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class Blocked
    {
        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8k)]
        public static void broadcast<T>(T src, in SpanBlock8<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var i=0; i<blocks; i++)
                broadcast(src, dst.CellBlock(i));
        }

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="src">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16k)]
        public static void broadcast<T>(T src, in SpanBlock16<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var i=0; i<blocks; i++)
                broadcast(src, dst.CellBlock(i));
        }

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="src">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(Numeric8x16x32k)]
        public static void broadcast<T>(T src, in SpanBlock32<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var i=0; i<blocks; i++)
                broadcast(src, dst.CellBlock(i));
        }

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="src">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(AllNumeric)]
        public static void broadcast<T>(T src, in SpanBlock64<T> dst)
            where T : unmanaged
        {
            var blocks = dst.BlockCount;
            for(var i=0; i<blocks; i++)
                broadcast(src, dst.CellBlock(i));
        }

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="src">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(AllNumeric)]
        public static void broadcast<T>(T src, in SpanBlock128<T> dst)
            where T : unmanaged
                => dst.Fill(src);

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="src">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(AllNumeric)]
        public static void broadcast<T>(T src, in SpanBlock256<T> dst)
            where T : unmanaged
                => dst.Fill(src);

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="src">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(AllNumeric)]
        public static void broadcast<T>(T src, in SpanBlock512<T> dst)
            where T : unmanaged
                => dst.Fill(src);

        /// <summary>
        /// Expands a bit-level S-pattern to a block-level T-pattern
        /// </summary>
        /// <param name="src">The source pattern</param>
        /// <param name="enabled">The value to assign to a block when the corresponding index-identified bit is enabled</param>
        /// <param name="dst">The target pattern receiver</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly SpanBlock128<T> broadcast<S,T>(S src, T enabled, in SpanBlock128<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            var length = root.min(dst.CellCount, width<S>());
            for(var i=0; i<length; i++)
                dst[i] = gbits.testbit(src, (byte)i) ? enabled : default;
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
        public static ref readonly SpanBlock256<T> broadcast<S,T>(S src, T enabled, in SpanBlock256<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            var length = root.min(dst.CellCount, width<S>());
            for(var i=0; i<length; i++)
                dst[i] = gbits.testbit(src,(byte)i) ? enabled : default;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static void broadcast<T>(T src, Span<T> dst)
        {
            var count = dst.Length;
            for(var i=0; i<count; i++)
                seek(dst,i) = src;
        }
    }
}