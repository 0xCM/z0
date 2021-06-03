//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    partial struct Tables
    {
        public static Outcome header(string src, char delimiter, out RowHeader dst)
        {
            if(text.empty(src))
            {
                dst = RowHeader.Empty;
                return (false,"The source text is empty");
            }
            else
            {
                try
                {
                    var parts = text.split(src, delimiter, false).View;
                    var count = parts.Length;
                    var cells = alloc<HeaderCell>(count);
                    ref var cell = ref first(cells);
                    for(var i=0u; i<count; i++)
                    {
                        ref readonly var content = ref skip(parts,i);
                        var length = (ushort)content.Length;
                        var name = text.trim(content);
                        seek(cell,i) = new HeaderCell(i,name, length);
                    }
                    dst = new RowHeader(cells, delimiter);
                    return true;
                }
                catch(Exception e)
                {
                    dst = RowHeader.Empty;
                    return e;
                }
            }
        }

        /// <summary>
        /// Creates a row header for parametrically-identified record type
        /// </summary>
        /// <param name="widths">The cell render widths</param>
        /// <typeparam name="T">The record type</typeparam>
        public static RowHeader header<T>(ReadOnlySpan<byte> widths, string delimiter = DefaultDelimiter)
            where T : struct
                => header(typeof(T), widths);

        /// <summary>
        /// Creates a row header for parametrically-identified record type and uniform field width
        /// </summary>
        /// <param name="fieldwidht">The uniform field width</param>
        /// <typeparam name="T">The record type</typeparam>
        public static RowHeader header<T>(byte fieldwidth, string delimiter = DefaultDelimiter)
            where T : struct
                => header(typeof(T), fieldwidth, delimiter);

        /// <summary>
        /// Creates a row header for a specified record type record type and uniform field width
        /// </summary>
        /// <param name="fieldwidht">The uniform field width</param>
        /// <typeparam name="T">The record type</typeparam>
        public static RowHeader header(Type record, byte fieldwidth, string delimiter = DefaultDelimiter)
        {
            var _fields = @readonly(fields(record));
            var count = _fields.Length;
            var buffer = alloc<HeaderCell>(count);
            var cells = span(buffer);
            for(var i=0u; i<count; i++)
                seek(cells, i) = new HeaderCell(i, skip(_fields,i).Name, fieldwidth);
            return new RowHeader(buffer, delimiter);
        }

        /// <summary>
        /// Creates a row header for a specified record type
        /// </summary>
        /// <param name="widths">The cell render widths</param>
        public static RowHeader header(Type record, ReadOnlySpan<byte> widths, string delimiter = DefaultDelimiter)
        {
            var _fields = @readonly(fields(record));
            var count = _fields.Length;
            if(count != widths.Length)
                sys.@throw(FieldCountMismatch.Format(count, widths.Length));
            var buffer = alloc<HeaderCell>(count);
            var cells = span(buffer);
            for(var i=0u; i<count; i++)
                seek(cells,i) = new HeaderCell(i, skip(_fields,i).Name, skip(widths,i));
            return new RowHeader(buffer, delimiter);
        }

        public static MsgPattern<Count,Count> FieldCountMismatch
            => "The target requires {0} fields but {1} were found in the source";
    }
}