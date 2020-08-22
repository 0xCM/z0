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

    partial struct Table
    {
        [Op, Closures(AllNumeric)]
        public static ReadOnlySpan<string> cells<T>(in CellFormatter<T,string> formatter, ReadOnlySpan<T> src)
        {
            var dst = span<string>(src.Length);
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = cell(formatter, skip(src,i));
            return dst;
        }

        /// <summary>
        /// Creates a <see cref='StringTableCells'/> sequence from a <see cref='string'/> array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline), Op]
        public static StringTableCells cells(string[] src)
            => new StringTableCells(src);

        [MethodImpl(Inline), Op]
        public static StringTableCells<T> cells<T>(StringTableCell<T>[] src)
            where T : ITextual
                => new StringTableCells<T>(src);
    }
}