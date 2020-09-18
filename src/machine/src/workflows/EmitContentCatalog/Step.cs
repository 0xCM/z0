//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = ContentLibField;

    public ref struct EmitContentCatalog
    {
        public readonly FilePath TargetPath;

        public uint EmissionCount;

        readonly IWfShell Wf;

        readonly EmitContentCatalogHost Host;

        [MethodImpl(Inline)]
        public EmitContentCatalog(IWfShell wf, EmitContentCatalogHost host)
        {
            Wf = wf;
            Host = host;
            TargetPath =  Wf.IndexRoot + FileName.define("catalog", FileExtensions.Csv);
            EmissionCount = 0;
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Emitting<DocLibEntry>(Host, FS.path(TargetPath.Name));

            var provider = Docs.content<TableContentProvider>();
            var entries = z.span(provider.Provided.Array());
            EmissionCount = (uint)entries.Length;

            var f = Table.formatter<ContentLibField>();
            for(var i=0u; i<EmissionCount; i++)
            {
                ref readonly var entry = ref z.skip(entries, i);
                f.Append(F.Type, entry.Type);
                f.Delimit(F.Name, entry.Name);
                f.EmitEol();
            }

            using var dst = TargetPath.Writer();
            dst.Write(f.Format());

            Wf.Emitted<DocLibEntry>(Host, EmissionCount, FS.path(TargetPath.Name));
        }
    }
}