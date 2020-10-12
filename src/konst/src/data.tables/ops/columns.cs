//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Table
    {
        [Op]
        public static ReadOnlySpan<TableColumn> columns(Type table, ReadOnlySpan<byte> widths)
        {
            var fields = span(table.DeclaredInstanceFields());
            var count = fields.Length;
            var dst = span<TableColumn>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                seek(dst,i) = new TableColumn((ushort)i, field.Name, skip(widths,i));
            }
            return dst;
        }

        [Op]
        public static ReadOnlySpan<TableColumn> columns<E>()
            where E : unmanaged, Enum
        {
            var fields = span(typeof(E).LiteralFields());
            var count = fields.Length;
            var dst = span<TableColumn>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                seek(dst,i) = new TableColumn((ushort)i, field.Name, (ushort)rebox(field.GetRawConstantValue(), NumericKind.U16));
            }
            return dst;
        }
    }
}