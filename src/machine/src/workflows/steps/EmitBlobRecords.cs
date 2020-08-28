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
    using static z;

    public ref struct EmitBlobs
    {
        public uint EmissionCount;

        public readonly FolderPath TargetDir;

        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        readonly IPart[] Parts;

        [MethodImpl(Inline)]
        public EmitBlobs(IWfContext wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            TargetDir = wf.ResourceRoot + FolderName.Define("blobs");
            EmissionCount = 0;
            Wf.Created(StepId, ct);
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

            Wf.Emitting(StepId, EmissionType, dstPath);

            var data = Read(part);
            var count = (uint)data.Length;
            var target = PartRecords.sink(ImageRecords.Blobs);

            for(var i=0u; i<count; i++)
                target.Deposit(skip(data,i));

            using var writer = dstPath.Writer();
            writer.Write(target.Render());

            Wf.Emitted(StepId, EmissionType, count, dstPath);

            EmissionCount += count;
        }

        public void Run()
        {
            Wf.Running(StepId, new {EmissionType, TargetDir});

            foreach(var part in Parts)
                Emit(part);

            Wf.Ran(StepId, new {EmissionType, EmissionCount, TargetDir});
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }
    }
}