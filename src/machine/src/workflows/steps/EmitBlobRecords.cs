//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static PartRecords;
    using static z;
    
    public readonly ref struct EmitBlobRecords
    {
        readonly WfContext Wf;

        readonly IPart[] Parts;

        readonly FolderPath TargetDir;

        readonly EmissionDataType DataType;

        readonly CorrelationToken Ct;
        
        [MethodImpl(Inline)]
        public EmitBlobRecords(WfContext wf, CorrelationToken ct, IPart[] parts)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            TargetDir = wf.AppPaths.ResourceRoot + FolderName.Define("blobs");
            DataType = EmissionDataType.Blob;
            Wf.Created(nameof(EmitBlobRecords), ct);
        }

        public ReadOnlySpan<ImgBlobRecord> Read(IPart part)
        {
            using var reader = ImgMetadataReader.open(part.PartPath());
            return reader.ReadBlobs();        
        }
                
        void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath =  TargetDir + FileName.Define(id.Format(), "blob.csv");

            Wf.Emitting($"{DataType}", dstPath);            

            var data = Read(part);
            var count = data.Length;     
            var target = PartRecords.sink(PartRecordSpecs.Blobs);

            for(var i=0u; i<count; i++)
                target.Deposit(skip(data,i));

            using var writer = dstPath.Writer();
            writer.Write(target.Render());

            Wf.Emitted(DataType.ToString(), (uint)count, dstPath);            
            
        }
        
        public void Run()
        {
            foreach(var part in Parts)
                Emit(part);
        }

        public void Dispose()
        {
            Wf.Finished(nameof(EmitBlobRecords), Ct);            
        }
    }
}