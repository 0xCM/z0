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
    using static EnumCatalogService;

    [ApiHost(ApiNames.EnumCatalog, true)]
    public readonly struct EnumCatalogService
    {
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

    [Step]
    public sealed class EmitEnumCatalog : WfHost<EmitEnumCatalog>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitEnumCatalogStep(wf, this);
            step.Run();
        }
    }

    public readonly ref struct EmitEnumCatalogStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly FS.FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmitEnumCatalogStep(IWfShell context, WfHost host)
        {
            Wf = context;
            Host = host;
            TargetPath = FS.path((Wf.IndexRoot + FileName.define("enums", FileExtensions.Csv)).Name);
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            var parts = ApiCatalogs.types(ClrTypeKind.Enum, Wf.Api);
            var dst = z.list<EnumLiteralRow>();
            for(var i=0; i<parts.Length; i++)
            {
                var x = parts[i];
                for(var j=0u; j<x.Length; j++)
                {
                    var y = x[j];
                    (var part, var type) = y;
                    var records = rows(part,type);
                    for(var k = 0; k<records.Length; k++)
                        dst.Add(records[k]);
                }
            }

            var m = dst.ToArray();
            Array.Sort(m);

            var formatter = Table.formatter<EnumLiteralRow.Fields>();
            formatter.EmitHeader();

            for(var i=0; i<m.Length; i++)
                EnumLiteralRow.format(m[i], formatter);

            using var writer = TargetPath.Writer();
            writer.Write(formatter.Format());

            Wf.EmittedTable(Host, typeof(EnumLiteralRow), m.Length, TargetPath);
        }
    }
}