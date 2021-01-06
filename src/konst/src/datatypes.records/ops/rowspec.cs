//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Records
    {
        /// <summary>
        /// Defines a <see cref='RowFormatSpec'/>
        /// </summary>
        /// <param name="header">The row header</param>
        /// <param name="cells">The cell specs</param>
        [MethodImpl(Inline), Op]
        public static RowFormatSpec rowspec(RowHeader header, CellFormatSpec[] cells)
            => new RowFormatSpec(header, cells);

        /// <summary>
        /// Defines a <see cref='RowFormatSpec'/>
        /// </summary>
        /// <param name="widths">The cell widths</param>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static RowFormatSpec rowspec<T>(ReadOnlySpan<byte> widths)
            where T : struct
        {
            var header = Records.header<T>(widths);
            return Records.rowspec(header, header.Cells.Select(x => x.CellFormat));
        }

        /// <summary>
        /// Defines a <see cref='RowFormatSpec'/>
        /// </summary>
        /// <param name="fieldwidth">The uniform field width</param>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static RowFormatSpec rowspec<T>(byte fieldwidth)
            where T : struct
        {
            var header = header<T>(fieldwidth);
            return Records.rowspec(header, header.Cells.Select(x => x.CellFormat));
        }

        /// <summary>
        /// Defines a <see cref='RowFormatSpec'/>
        /// </summary>
        /// <param name="record">The record type</param>
        /// <param name="fieldwidth">The uniform field width</param>
        [Op, Closures(Closure)]
        public static RowFormatSpec rowspec(Type record, byte fieldwidth)
        {
            var header = Records.header(record, fieldwidth);
            return Records.rowspec(header, header.Cells.Select(x => x.CellFormat));
        }
    }
}