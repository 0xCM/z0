//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitConstantDatasetsStep;
    using static RenderPatterns;
    using static z;
    
    public readonly ref struct EmitConstantDatasets
    {        
        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        readonly FolderPath TargetDir;

        readonly IPart[] Parts;
        
        [MethodImpl(Inline)]
        public EmitConstantDatasets(IWfContext wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            TargetDir = wf.ResourceRoot + FolderName.Define("constants");
            Wf.Created(StepName, Ct);
        }
                        
        public void Run()
        {
            Wf.Running(StepName, Ct);

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
            
            Wf.Ran(StepName, Ct);
        }

        ReadOnlySpan<ImgConstantRecord> Read(IPart part)
        {
            using var reader = PeMetaReader.open(part.PartPath());
            return reader.ReadConstants();        
        }
        
        void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath = TargetDir + FileName.Define(id.Format(), DataExt);
            Wf.Running(StepName, dstPath.Name, Ct);
            
            var data = Read(part);
            var count = data.Length;            
            var dst = PartRecords.formatter(ImageRecords.Constants);
            
            dst.EmitHeader();
            for(var i=0u; i<count; i++)
                PartRecords.format(skip(data,i), dst);

            using var writer = dstPath.Writer();
            writer.Write(dst.Render());

            Wf.RanT(StepName, new {PartId = id, Count = count}, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);
        }
    }
}