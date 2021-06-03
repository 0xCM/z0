//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct RecordFormatter
    {
        public static string header(in RowFormatSpec rowspec)
            => rowspec.Header.Format();

        public static uint cells<T>(in RowFormatSpec rowspec, in DynamicRow<T> row, Span<string> dst)
            where T : struct, IRecord<T>
        {
            var values = @readonly(row.Cells);
            var specs = rowspec.Cells.View;
            var count = (uint)min(specs.Length,values.Length);
            for(var i=0; i<count; i++)
            {
                ref readonly var value = ref skip(values,i);
                ref readonly var spec = ref skip(specs,i);
                var cellpad = spec.Width.Pattern();
                seek(dst, i) = string.Format(cellpad, spec.Pattern.Format(value));
            }

            return count;
        }

        public static string format<T>(in RowFormatSpec rowspec, in DynamicRow<T> src)
            where T : struct, IRecord<T>
        {
            var content = string.Format(rowspec.Pattern, src.Cells);
            var pad = rowspec.RowPad;
            if(pad == 0)
                return content;
            else
                return content.PadRight(pad);
        }

        public static string pairs<T>(in RowAdapter<T> src)
            where T : struct, IRecord<T>
        {
            const char RowSep = Chars.Comma;
            const char ValSep = Chars.Eq;
            const string KVRP = "{0,-48}: {1}" + Eol;

            var dst = text.buffer();
            var cells = src.Cells;
            var count = cells.Length;
            var fields = src.Fields.View;
            for(var i=0; i<count; i++)
                dst.AppendFormat(KVRP, skip(fields,i).Name, skip(cells,i));
            return dst.Emit();
        }
    }
}