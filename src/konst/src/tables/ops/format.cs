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

    partial struct Tables
    {
        /// <summary>
        /// Formats a <see cref='DynamicRow{T}'/> according to supplied specifiecation
        /// </summary>
        /// <param name="row">The row to format</param>
        /// <param name="spec">The format spec</param>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(DynamicRow<T> row, RowFormatSpec spec)
            where T : struct
                => string.Format(spec.Pattern, row.Cells);

        [Op]
        static string format(dynamic src, CellFormatSpec spec)
        {
            string data = spec.Pattern.Format(src);
            if(spec.Width != 0)
                data.PadRight(spec.Width);
            return data;
        }

        [Op, Closures(Closure)]
        public static void render<T>(DynamicRow<T> src, in RowFormatSpec spec, ITextBuffer dst)
            where T : struct
        {
            var count = spec.CellCount;
            ref readonly var cf = ref spec.Cells.First;
            ref readonly var cd = ref first(src.View);
            for(var i=0; i<count; i++)
                dst.Append(format(skip(cd,i), skip(cf,i)));
        }
    }
}