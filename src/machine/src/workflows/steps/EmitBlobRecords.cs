//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitBlobsStep;
    using static Flow;
    using static z;

    [Step(WfStepId.EmitBlobs, true)]
    public readonly struct EmitBlobsStep
    {
        public const string WorkerName = nameof(EmitBlobs);        

        public const string DatasetName = "Metablobs";
    }    

    [Step(WfStepId.EmitBlobs)]
    public ref struct EmitBlobs
    {
        public uint EmissionCount;

        public readonly FolderPath TargetDir;

        readonly WfContext Wf;

        readonly CorrelationToken Ct;

        readonly IPart[] Parts;
        
        [MethodImpl(Inline)]
        public EmitBlobs(WfContext wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            TargetDir = wf.AppPaths.ResourceRoot + FolderName.Define("blobs");
            EmissionCount = 0;
            Wf.Created(WorkerName, ct);
        }

        public ReadOnlySpan<ImgBlobRecord> Read(IPart part)
        {
            using var reader = PeMetaReader.open(part.PartPath());
            return reader.ReadBlobs();        
        }
                
        void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath =  TargetDir + FileName.Define(id.Format(), "blob.csv");

            Wf.Emitting(WorkerName, DatasetName, dstPath, Ct);            

            var data = Read(part);
            var count = (uint)data.Length;     
            var target = PartRecords.sink(ImageRecords.Blobs);

            for(var i=0u; i<count; i++)
                target.Deposit(skip(data,i));

            using var writer = dstPath.Writer();
            writer.Write(target.Render());

            Wf.Emitted(WorkerName, DatasetName, count, dstPath, Ct);                        

            EmissionCount += count;
        }
        
        public void Run()
        {
            Wf.RunningT(WorkerName, new {DatasetName, TargetDir}, Ct);
            
            foreach(var part in Parts)
                Emit(part);

            Wf.RanT(WorkerName, new {DatasetName, EmissionCount, TargetDir}, Ct);

        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);            
        }
    }
}