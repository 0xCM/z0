//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

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
            var parts = ApiQuery.types(ClrTypeKind.Enum, Wf.Api);
            var dst = z.list<EnumLiteralRow>();
            for(var i=0; i<parts.Length; i++)
            {
                var x = parts[i];
                for(var j=0u; j<x.Length; j++)
                {
                    var y = x[j];
                    (var part, var type) = y;
                    var records = Enums.enums(part,type);
                    for(var k = 0; k<records.Length; k++)
                        dst.Add(records[k]);
                }
            }

            var m = dst.ToArray();
            Array.Sort(m);

            var formatter = Table.formatter<EnumLiteralTableField>();
            formatter.EmitHeader();

            for(var i=0; i<m.Length; i++)
                Enums.format(m[i],formatter);

            using var writer = TargetPath.Writer();
            writer.Write(formatter.Format());

            Wf.Raise(new EmittedEnumCatalog(Host, TargetPath, (uint)m.Length, Wf.Ct));
        }
    }
}