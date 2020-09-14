//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static BufferBlocks;

    partial class Blocked
    {
        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8k)]
        public static void broadcast<T>(T data, in SpanBlock8<T> dst)
            where T : unmanaged
        {
            if(aligned<T>(w128,dst.CellCount))
            {
                for(var i=0; i<dst.BlockCount; i++)
                    z.vload(n128, dst.Block(i));
            }
        }

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16k)]
        public static void broadcast<T>(T data, in SpanBlock16<T> dst)
            where T : unmanaged
                => dst.Fill(data);

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(Numeric8x16x32k)]
        public static void broadcast<T>(T data, in SpanBlock32<T> dst)
            where T : unmanaged
                => dst.Fill(data);

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(AllNumeric)]
        public static void broadcast<T>(T data, in SpanBlock64<T> dst)
            where T : unmanaged
                => dst.Fill(data);

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(AllNumeric)]
        public static void broadcast<T>(T data, in SpanBlock128<T> dst)
            where T : unmanaged
                => dst.Fill(data);

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(AllNumeric)]
        public static void broadcast<T>(T data, in SpanBlock256<T> dst)
            where T : unmanaged
                => dst.Fill(data);

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(AllNumeric)]
        public static void broadcast<T>(T data, in SpanBlock512<T> dst)
            where T : unmanaged
                => dst.Fill(data);
    }
}