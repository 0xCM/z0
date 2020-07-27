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
        readonly IWfPartEmission Wf;

        readonly IPart[] Parts;
        
        [MethodImpl(Inline)]
        public EmitBlobRecords(IWfPartEmission wf, IPart[] parts)
        {
            Wf = wf;
            Parts = parts;
            StepKind.Emitting(Wf);            
        }

        public EmissionDataType StepKind 
            => EmissionDataType.Blob;        

        public PartRecordKind DataKind
            => PartRecordKind.Blob;                

        public ReadOnlySpan<BlobRecord> Read(IPart part)
        {
            var srcPath = Wf.PartPath(part);              
            using var reader = PartReader.open(srcPath);
            return reader.ReadBlobs();        
        }
                
        void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath = Wf.TargetPath(id, StepKind);

            DataKind.Emitting(dstPath, Wf);

            var data = Read(part);
            var count = data.Length;     
            var target = PartRecords.sink(Wf.DataTypes.Blobs);

            for(var i=0u; i<count; i++)
                target.Deposit(skip(data,i));

            using var writer = dstPath.Writer();
            writer.Write(target.Render());

            DataEmitters.emitted(Wf, DataKind, id, count);
        }
        
        public void Run()
        {
            foreach(var part in Parts)
                Emit(part);

        }

        public void Dispose()
        {
            StepKind.Emitted(Wf);
        }
    }
}