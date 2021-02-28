//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Cells
    {
        [Op]
        public static string format(Cell8 src)
            => src.Content.FormatHex();

        [Op]
        public static string format(Cell16 src)
            => src.Content.FormatHex();

        [Op]
        public static string format(Cell32 src)
            => src.Content.FormatHex();

        [Op]
        public static string format(Cell64 src)
            => src.Content.FormatHex();

        public static string format(CellQ src)
            => src.Kind switch{
                CellKind.Cell8 => memory.first(src.Bytes).FormatHex(),
                CellKind.Cell16 => memory.first16u(src.Bytes).FormatHex(),
                CellKind.Cell32 => memory.first32u(src.Bytes).FormatHex(),
                CellKind.Cell64 => memory.first64u(src.Bytes).FormatHex(),
                _ => src.Bytes.FormatHex()
            };
    }
}