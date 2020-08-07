//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
    using static EmitContentCatalogStep;
    
    using F = ContentLibField;
    
    [Step(WfStepKind.EmitContentCatalog)]
    public ref struct EmitContentCatalog
    {
        public readonly FilePath TargetPath;
        
        public uint EmissionCount;

        readonly WfContext Wf;

        readonly CorrelationToken Ct;
        
        [MethodImpl(Inline)]
        public EmitContentCatalog(WfContext wf, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            TargetPath =  Wf.IndexRoot + FileName.Define("catalog", FileExtensions.Csv);
            EmissionCount = 0;
            Wf.Created(WorkerName, Ct);
        }

        public void Run()
        {
            Wf.Emitting(WorkerName, DatasetName, TargetPath, Ct);
            var entries = z.span(ZTables.Catalog.Array());
            EmissionCount = (uint)entries.Length;

            var f = formatter<ContentLibField>();
            for(var i=0u; i<EmissionCount; i++)
            {
                ref readonly var entry = ref z.skip(entries, i);
                f.Append(F.Kind, entry.Kind);
                f.Delimit(F.Structure, entry.Structure);
                f.Delimit(F.Size, entry.Size);
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