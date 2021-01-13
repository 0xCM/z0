//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static z;

    [ApiHost(ApiNames.EnumCatalogs, true)]
    public readonly struct EnumCatalogs
    {
        [Op]
        public static ReadOnlySpan<EnumLiteralRow> enums(ClrAssemblyName part, Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = span<EnumLiteralRow>(fields.Length);
            var ecode = ClrPrimitives.ecode(src);
            fill(part, src, ecode, fields, dst);
            return dst;
        }

        [Op]
        static void fill(ClrAssemblyName part, Type type, ClrEnumCode ecode, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteralRow> dst)
        {
            var count = fields.Length;
            var typeAddress = type.TypeHandle.Value;
            var asmName = part.SimpleName;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                ref var row = ref seek(dst,i);
                row.Component = asmName;
                row.Type = type.Name;
                row.DataType = ecode;
                row.LiteraIndex = (ushort)i;
                row.LiteralName = f.Name;
                row.ScalarValue = Enums.unbox(ecode, f.GetRawConstantValue());
                row.NameAddress = memory.address(f.Name);
                row.TypeAddress = typeAddress;
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
                if(row.BlockCount >= 3)
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

        public static WfExecToken emit(IWfShell wf, FS.FilePath target)
        {
            var flow = wf.EmittingTable<EnumLiteralRow>(target);
            var typesIndex = Clr.enums(wf.Components);
            var partCount = typesIndex.Length;
            var dst = list<EnumLiteralRow>();
            for(var i=0; i<partCount; i++)
            {
                var types = typesIndex[i];
                for(var j=0u; j<types.Length; j++)
                {
                    var kv = types[j];
                    (var asm, var type) = kv;
                    var records = enums(asm, type);
                    var kEnums = records.Length;
                    for(var k=0; k<kEnums; k++)
                        dst.Add(records[k]);
                }
            }

            var rows = dst.ToArray();
            var rc = rows.Length;
            Array.Sort(rows);

            using var writer = target.Writer();
            var formatter = Records.formatter<EnumLiteralRow>(16);
            writer.WriteLine(formatter.FormatHeader());

            for(var i=0; i<rc; i++)
                writer.WriteLine(formatter.Format(rows[i]));

            return wf.EmittedTable<EnumLiteralRow>(flow, rows.Length, target);
        }

        public static void emit(IWfShell wf)
        {
            var target = wf.Db().IndexTable(EnumLiteralRow.TableId);
            emit(wf, target);
        }
    }
}