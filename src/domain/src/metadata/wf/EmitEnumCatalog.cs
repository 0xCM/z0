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
    using static ApiEnumCatalog;

    [WfHost]
    public sealed class EmitEnumCatalog : WfHost<EmitEnumCatalog>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitEnumCatalogStep(wf, this);
            step.Run();
        }
    }

    readonly ref struct EmitEnumCatalogStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public EmitEnumCatalogStep(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            var parts = ApiCatalogs.types(ClrTypeKind.Enum, Wf.Api);
            var target = Wf.Db().Table(EnumLiteralRow.TableId);
            var dst = z.list<EnumLiteralRow>();
            for(var i=0; i<parts.Length; i++)
            {
                var x = parts[i];
                for(var j=0u; j<x.Length; j++)
                {
                    var y = x[j];
                    (var part, var type) = y;
                    var records = enums(part,type);
                    for(var k = 0; k<records.Length; k++)
                        dst.Add(records[k]);
                }
            }

            var rows = dst.ToArray();
            Array.Sort(rows);

            var formatter = Table.formatter<EnumLiteralRow.Fields>();
            formatter.EmitHeader();

            for(var i=0; i<rows.Length; i++)
                EnumLiteralRow.format(rows[i], formatter);

            using var writer = target.Writer();
            writer.Write(formatter.Format());

            Wf.EmittedTable(typeof(EnumLiteralRow), rows.Length, target);
        }
    }
}