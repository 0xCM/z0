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
        readonly IAppContext Wf;

        readonly IPart[] Parts;

        readonly FolderPath TargetDir;

        readonly EmissionDataType DataType;
        
        [MethodImpl(Inline)]
        public EmitBlobRecords(IAppContext wf, IPart[] parts)
        {
            Wf = wf;
            Parts = parts;
            TargetDir = wf.AppPaths.ResourceRoot + FolderName.Define("blobs");
            DataType = EmissionDataType.Blob;
            DataType.Emitting(Wf);            
        }

        public PartRecordKind DataKind
            => PartRecordKind.Blob;                

        public ReadOnlySpan<BlobRecord> Read(IPart part)
        {
            using var reader = PartReader.open(part.PartPath());
            return reader.ReadBlobs();        
        }
                
        void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath =  TargetDir + FileName.Define(id.Format(), "blob.csv");

            DataKind.Emitting(dstPath, Wf);

            var data = Read(part);
            var count = data.Length;     
            var target = PartRecords.sink(PartRecordSpecs.Blobs);

            for(var i=0u; i<count; i++)
                target.Deposit(skip(data,i));

            using var writer = dstPath.Writer();
            writer.Write(target.Render());

            TableEmission.emitted(Wf, DataKind, id, count);
        }
        
        public void Run()
        {
            foreach(var part in Parts)
                Emit(part);
        }

        public void Dispose()
        {
            DataType.Emitted(Wf);
        }
    }
}