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

    partial class Cells
    {
        /// <summary>
        /// Creates a <see cref='Cell32'/> from a specified <see cref='int'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell32 cell32(int src)
            => src;

        /// <summary>
        /// Creates a <see cref='Cell32'/> from a specified <see cref='uint'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell32 cell32(uint src)
            => src;

        /// <summary>
        /// Seeks an index-identified <see cref='Cell32'/> value from a specified <see cref='Cell64'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell32 cell32(in Cell64 src, uint1 part)
            => ref seek(@as<Cell64,Cell32>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell32'/> value from a specified <see cref='Cell128'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell32 cell32(in Cell128 src, uint2 part)
            => ref seek(@as<Cell128,Cell32>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell32'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell32 cell32(in Cell256 src, uint3 part)
            => ref seek(@as<Cell256,Cell32>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell32'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell32 cell32(in Cell512 src, uint4 part)
            => ref seek(@as<Cell512,Cell32>(src), part);
    }
}