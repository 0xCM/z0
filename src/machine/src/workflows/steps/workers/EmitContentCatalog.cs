//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;

    using static Konst;
    using static Flow;
    using static EmitContentCatalogStep;
    
    using F = ContentLibField;
    
    [Step(WfStepKind.EmitContentCatalog)]
    public ref struct EmitContentCatalog
    {
        public readonly FilePath TargetPath;
        
        public uint EmissionCount;

        readonly IWfContext Wf;

        readonly CorrelationToken Ct;
        
        [MethodImpl(Inline)]
        public EmitContentCatalog(IWfContext wf, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            TargetPath =  Wf.IndexRoot + FileName.Define("catalog", FileExtensions.Csv);
            EmissionCount = 0;
            Wf.Created(WorkerName, Ct);
        }

        public void Run()
        {
            var provider = TableProvider.create();
            Wf.Emitting(WorkerName, DatasetName, TargetPath, Ct);
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

            Wf.Emitted(WorkerName, DatasetName, EmissionCount, TargetPath, Ct);
        }

        public void Dispose()        
        {
            Wf.Finished(WorkerName, Ct);
        }
    }
}