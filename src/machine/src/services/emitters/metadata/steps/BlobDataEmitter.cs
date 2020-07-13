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

    partial class XTend
    {
        public static void Deposit(this BlobRecord src, IDatasetFormatter<BlobField> dst)
        {
            dst.Delimit(BlobField.Sequence, src.Sequence);
            dst.Delimit(BlobField.HeapSize, src.HeapSize);
            dst.Delimit(BlobField.Offset, src.Offset);
            dst.Delimit(BlobField.Value, src.Value);
            dst.EmitEol();            
        }

        public static DatasetSink<BlobField,BlobRecord> Sink(this IMetadataWorkflow wf, BlobField f = default)
            => PartRecords.sink(wf.DataTypes.Blobs);
    }
    
    public readonly struct BlobDataEmitter : IDataEmitter
    {
        readonly IMetadataWorkflow Wf;
        
        [MethodImpl(Inline)]
        public BlobDataEmitter(IMetadataWorkflow wf)
        {
            Wf = wf;
        }

        public MetadataEmissionKind StepKind 
            => MetadataEmissionKind.Blob;        

        public PartRecordKind DataKind
            => PartRecordKind.Blob;                

        public ReadOnlySpan<BlobRecord> Read(IPart part)
        {
            var srcPath = Wf.PartPath(part);              
            using var reader = PartReader.open(srcPath);
            return reader.ReadBlobs();        
        }
                
        public void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath = Wf.TargetPath(id, StepKind);

            DataKind.Emitting(dstPath, Wf);

            var data = Read(part);
            var count = data.Length;            
            var target = Wf.Sink(default(BlobField));

            for(var i=0u; i<count; i++)
                target.Deposit(skip(data,i));

            using var writer = dstPath.Writer();
            writer.Write(target.Render());

            DataEmitters.emitted(Wf, DataKind, id, count);
        }
        
        public void Emit(IPart[] parts)
        {
            StepKind.Emitting(Wf);

            foreach(var part in parts)
                Emit(part);

            StepKind.Emitted(Wf);
        }
    }
}