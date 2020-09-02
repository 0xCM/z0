//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitContentCatalogStep;

    using F = ContentLibField;

    public ref struct EmitContentCatalog
    {
        public readonly FilePath TargetPath;

        public uint EmissionCount;

        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        [MethodImpl(Inline)]
        public EmitContentCatalog(IWfShell wf, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            TargetPath =  Wf.IndexRoot + FileName.define("catalog", FileExtensions.Csv);
            EmissionCount = 0;
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Emitting(StepId, DatasetName, TargetPath);

            var provider = TableProvider.create();
            var entries = z.span(provider.Provided.Array());
            EmissionCount = (uint)entries.Length;

            var f = TableFormat.formatter<ContentLibField>();
            for(var i=0u; i<EmissionCount; i++)
            {
                ref readonly var entry = ref z.skip(entries, i);
                f.Append(F.Type, entry.Type);
                f.Delimit(F.Name, entry.Name);
                f.EmitEol();
            }

            using var dst = TargetPath.Writer();
            dst.Write(f.Format());

            Wf.Emitted(StepId, DatasetName, EmissionCount, TargetPath);
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }
    }
}