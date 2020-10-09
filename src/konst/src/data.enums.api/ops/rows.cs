//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using F = EnumLiteralTableField;

    partial class Enums
    {
        public static void format(in EnumLiteralRow src, TableFormatter<EnumLiteralTableField> dst, bool eol = true)
        {
            dst.Delimit(F.PartId, src.PartId);
            dst.Delimit(F.TypeId, src.TypeId);
            dst.Delimit(F.TypeAddress, src.TypeAddress);
            dst.Delimit(F.NameAddress, src.NameAddress);
            dst.Delimit(F.TypeName, src.TypeName);
            dst.Delimit(F.DataType, src.PrimalKind);
            dst.Delimit(F.Index, src.Index);
            dst.Delimit(F.ScalarValue, src.ScalarValue);
            dst.Delimit(F.Name, src.Name);
            if(eol)
                dst.EmitEol();
        }

        [Op]
        public static ReadOnlySpan<EnumLiteralRow> rows(PartId part, Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = span<EnumLiteralRow>(fields.Length);
            var ecode = PrimalKinds.ecode(src);
            rows(part, src, ecode, fields, dst);
            return dst;
        }

        [Op]
        public static void rows(PartId part, Type type, EnumTypeCode ecode, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteralRow> dst)
        {
            var count = fields.Length;
            var address = type.TypeHandle.Value;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref z.skip(fields,i);
                var nameAddress = z.address(f.Name);
                seek(dst,i) = new EnumLiteralRow(part, type, address, (ushort)i, f.Name, nameAddress, (EnumScalarKind)ecode, Enums.unbox(ecode, f.GetRawConstantValue()));
            }
        }

        [Op]
        public static Span<EnumLiteralRow> rows(TextDoc src)
        {
            var rc = src.RowCount;
            var dst = z.alloc<EnumLiteralRow>(rc);
            for(var i=0; i<rc; i++)
            {
                ref readonly var row = ref src[i];
                if(row.CellCount >= 3)
                {
                    var data = row[2];
                    var result = HexByteParser.Service.ParseData(data);
                    if(result.Succeeded)
                    {
                        var bytes = z.span(result.Value);
                        var storage = 0ul;
                        ref var store = ref z.@as<ulong,byte>(storage);
                        var count = z.min(bytes.Length,8);
                        for(var j=0u; j<count; j++)
                            z.seek(store,j) = z.skip(bytes,j);

                        dst[i] = default;
                    }
                }
                else
                    dst[i] = default;
            }
            return dst;
        }
    }
}