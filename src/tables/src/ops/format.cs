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
        [Op]
        public static string format(ListedFiles src)
        {
            var dst = text.buffer();
            format(src,dst);
            return dst.Emit();
        }

        [Op]
        public static void format(ListedFiles src, ITextBuffer dst)
        {
            var records = src.View;
            var count = records.Length;
            var formatter = Tables.formatter<ListedFile>();
            dst.AppendLine(formatter.FormatHeader());
            for(var i=0u; i<count; i++)
            {
                ref readonly var listed = ref src[i];
                dst.AppendLine(formatter.Format(listed));
            }
        }

        [MethodImpl(Inline), Op]
        public static void format(ListedFiles src, Span<string> dst)
        {
            var count = src.Count;
            var listed = src.View;
            var formatter = Tables.formatter<ListedFile>();
            ref readonly var file = ref src[0];
            ref var formatted = ref first(dst);

            for(var i=0u; i<count; i++)
                seek(formatted,i) = formatter.Format(skip(file,i));
        }

        /// <summary>
        /// Formats a <see cref='RowHeader'/>
        /// </summary>
        /// <param name="src">The source header</param>
        public static string format(RowHeader src)
        {
            var dst = text.buffer();
            for(var i=0; i<src.Count; i++)
            {
                if(i != 0)
                    dst.Append(src.Delimiter);

                dst.Append(src[i].Format());
            }
            return dst.Emit();
        }

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