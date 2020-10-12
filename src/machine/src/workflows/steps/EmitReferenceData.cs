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

    using F = ContentLibField;

    [WfHost]
    public sealed class EmitReferenceData : WfHost<EmitReferenceData>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitReferenceDataStep(wf,this);
            step.Run();
        }
    }

    public ref struct EmitReferenceDataStep
    {
        public readonly FS.FilePath TargetPath;

        public uint EmissionCount;

        readonly IWfShell Wf;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public EmitReferenceDataStep(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            TargetPath =  Wf.Db().DbPaths.Doc("documents", FileKind.Csv);
            EmissionCount = 0;
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Running(Host);

            XedEtlWfHost.create().Run(Wf);

            var provider = TableContentProvider.create(Parts.Refs.Assembly);
            var entries = provider.Entries;
            EmissionCount = (uint)entries.Length;

            var f = Table.formatter<ContentLibField>();

            for(var i=0u; i<EmissionCount; i++)
            {
                ref readonly var entry = ref skip(entries, i);
                f.Append(F.Type, entry.Type);
                f.Delimit(F.Name, entry.Name);
                f.EmitEol();
            }

            using var dst = TargetPath.Writer();
            dst.Write(f.Format());

            Wf.EmittedTable<DocLibEntry>(Host, EmissionCount, FS.path(TargetPath.Name));
        }
    }
}