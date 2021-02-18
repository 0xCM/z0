//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Cells
    {
        [Op]
        public static string format(Cell8 src)
            => src.Content.FormatHexData();

        [Op]
        public static string format(Cell16 src)
            => src.Content.FormatHexData();

        [Op]
        public static string format(Cell32 src)
            => src.Content.FormatHexData();

        [Op]
        public static string format(Cell64 src)
            => src.Content.FormatHexData();

        public static string format(CellQ src)
            => src.Kind switch{
                CellKind.Cell8 => "",
                CellKind.Cell16 => "",
                CellKind.Cell32 => "",
                CellKind.Cell64 => "",
                _ => ""
            };


    }
}