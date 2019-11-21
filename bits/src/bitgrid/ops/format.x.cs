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

    partial class BitGrid
    {
        public static string Format<T>(this BitGrid<T> src)
            where T : unmanaged
                => src.ToBitString().Format(blockWidth:1,rowWidth:src.Width);

        public static string Format<T>(this RowBits<T> src)
            where T : unmanaged
            => src.Bytes.FormatMatrixBits(src.RowWidth);
        
        public static string Format(this GridMap map, int? colpad = null, char? delimiter = null)
            => BitGrid.format(map, colpad, delimiter);

        public static string Format(this GridStats stats, int? colpad = null, char? delimiter = null)
            => BitGrid.format(stats, colpad, delimiter);
    }
}