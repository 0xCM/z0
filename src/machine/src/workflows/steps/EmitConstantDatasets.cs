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
    using static EmitConstantDatasetsStep;
    using static z;

    [Step(WfStepId.EmitConstantDatasets, true)]
    public readonly struct EmitConstantDatasetsStep
    {
        public const string WorkerName = nameof(EmitConstantDatasets);

        public const WfStepId StepId = WfStepId.EmitConstantDatasets;
    }
    
    [Step(WfStepId.EmitConstantDatasets)]
    public readonly ref struct EmitConstantDatasets
    {        
        readonly WfContext Wf;

        readonly CorrelationToken Ct;

        readonly FolderPath TargetDir;

        readonly IPart[] Parts;
        
        [MethodImpl(Inline)]
        public EmitConstantDatasets(WfContext wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            TargetDir = wf.AppPaths.ResourceRoot + FolderName.Define("constants");
            Wf.Created(WorkerName, Ct);
        }
                        
        public void Run()
        {
            Wf.Running(WorkerName, Ct);

            foreach(var part in Parts)
            {
                try
                {
                    Emit(part);
                }
                catch(Exception e)
                {
                    Wf.Error(e, Ct);
                }
            }
            
            Wf.Ran(WorkerName, Ct);
        }


        ReadOnlySpan<ImgConstantRecord> Read(IPart part)
        {
            using var reader = ImgMetadataReader.open(part.PartPath());
            return reader.ReadConstants();        
        }
        
        void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath = TargetDir + FileName.Define(part.Id.Format(), FileExtensions.Csv);
            var ct = Wf.Running(nameof(EmitConstantDatasets), dstPath.Name);
            var data = Read(part);
            var count = data.Length;            
            var dst = PartRecords.formatter(PartRecordSpecs.Constants);
            
            dst.EmitHeader();
            for(var i=0u; i<count; i++)
                PartRecords.format(skip(data,i), dst);

            using var writer = dstPath.Writer();
            writer.Write(dst.Render());

            Wf.RanT(WorkerName, new {Id = id, Count = count}, ct);
        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }

    }
}