//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static memory;

    [ApiHost]
    public readonly partial struct TableFormatter
    {
        [Op, Closures(UInt64k)]
        public static RowFormatter<T> row<T>(ReadOnlySpan<byte> widths, T t = default, char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(fields<T>(widths), text.build(), FieldDelimiter);

        [Op, Closures(UInt64k)]
        public static TableFields fields<T>(ReadOnlySpan<byte> widths)
            where T : struct
        {
            var type = typeof(T);
            var declared = @readonly(type.DeclaredInstanceFields());
            var count = declared.Length;
            if(count != widths.Length)
                @throw(AppErrors.LengthMismatch(count, widths.Length));

            var buffer = alloc<TableField>(count);
            var fields = span(buffer);
            for(ushort i=0; i<count; i++)
                map(skip(declared,i), i, skip(widths,i), ref seek(fields,i));

            return new TableFields(buffer);
        }

        [MethodImpl(Inline), Op]
        public static ref TableField map(FieldInfo src, ushort index, byte width, ref TableField dst)
        {
            dst.Index = index;
            dst.RecordType = src.DeclaringType;
            dst.DataType = src.FieldType;
            dst.RenderWidth = width;
            dst.Definition = src;
            return ref dst;
        }
    }
}
