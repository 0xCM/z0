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
    using static EnumLiteralRow;

    [ApiHost(ApiNames.EnumCatalogs, true)]
    public readonly struct EnumCatalogs
    {
        [Op]
        public static ReadOnlySpan<EnumLiteralRow> enums(string part, Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = span<EnumLiteralRow>(fields.Length);
            var ecode = PrimalKinds.ecode(src);
            fill(part, src, ecode, fields, dst);
            return dst;
        }

        [Op]
        public static void fill(string part, Type type, EnumTypeCode ecode, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteralRow> dst)
        {
            var count = fields.Length;
            var address = type.TypeHandle.Value;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                var nameAddress = z.address(f.Name);
                seek(dst,i) = new EnumLiteralRow(part, type, address, (ushort)i, f.Name, nameAddress, (EnumScalarKind)ecode, Enums.unbox(ecode, f.GetRawConstantValue()));
            }
        }

        [Op]
        public static Span<EnumLiteralRow> enums(TextDoc src)
        {
            var rc = src.RowCount;
            var dst = alloc<EnumLiteralRow>(rc);
            for(var i=0; i<rc; i++)
            {
                ref readonly var row = ref src[i];
                if(row.CellCount >= 3)
                {
                    var data = row[2];
                    var result = HexByteParser.Service.ParseData(data);
                    if(result.Succeeded)
                    {
                        var bytes = span(result.Value);
                        var storage = 0ul;
                        ref var store = ref @as<ulong,byte>(storage);
                        var count = z.min(bytes.Length,8);
                        for(var j=0u; j<count; j++)
                            seek(store,j) = skip(bytes,j);

                        dst[i] = default;
                    }
                }
                else
                    dst[i] = default;
            }
            return dst;
        }

        [Op]
        public static void format(in EnumLiteralRow src, TableFormatter<Fields> dst, bool eol = true)
        {
            dst.Delimit(Fields.Component, src.Component);
            dst.Delimit(Fields.TypeId, src.TypeId);
            dst.Delimit(Fields.TypeAddress, src.TypeAddress);
            dst.Delimit(Fields.NameAddress, src.NameAddress);
            dst.Delimit(Fields.TypeName, src.TypeName);
            dst.Delimit(Fields.DataType, src.DataType);
            dst.Delimit(Fields.Index, src.Index);
            dst.Delimit(Fields.ScalarValue, src.ScalarValue);
            dst.Delimit(Fields.Name, src.Name);
            if(eol)
                dst.EmitEol();
        }

        public static void emit(IWfShell wf, PartId[] selection)
        {
            var parts = ApiQuery.enums(wf.Api, selection);
            var target = wf.Db().Table(EnumLiteralRow.TableId);
            var dst = list<EnumLiteralRow>();
            for(var i=0; i<parts.Length; i++)
            {
                var x = parts[i];
                for(var j=0u; j<x.Length; j++)
                {
                    var y = x[j];
                    (var part, var type) = y;
                    var component = part.Format();
                    var records = enums(component,type);
                    for(var k = 0; k<records.Length; k++)
                        dst.Add(records[k]);
                }
            }

            var rows = dst.ToArray();
            var rc = rows.Length;
            Array.Sort(rows);

            var formatter = Table.formatter<Fields>();
            formatter.EmitHeader();

            for(var i=0; i<rc; i++)
                format(rows[i], formatter);

            using var writer = target.Writer();
            writer.Write(formatter.Format());

            wf.EmittedTable(typeof(EnumLiteralRow), rows.Length, target);
        }

        [Op]
        public static void emit(IWfShell wf)
            => emit(wf, wf.Api.PartIdentities);
    }
}