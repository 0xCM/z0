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
    using static EmitFieldMetadataStep;

    [Step(WfStepId.EmitFieldMetadata, true)]
    public readonly struct EmitFieldMetadataStep
    {
        public const string WorkerName = nameof(EmitFieldMetadata);

        public const string DataType = "FieldMetadata";

        public const string DatasetName = "FieldMetadata";
    }

    [Step(WfStepId.EmitFieldMetadata)]
    public readonly ref struct EmitFieldMetadata
    {    
        readonly WfContext Wf;

        readonly CorrelationToken Ct;

        readonly IPart[] Parts;
        
        readonly ImgFieldRecord Spec;

        readonly FolderPath TargetDir;

        [MethodImpl(Inline)]
        public EmitFieldMetadata(WfContext wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            Spec = ImageRecords.Fields;
            TargetDir = wf.AppPaths.ResourceRoot + FolderName.Define("fields");
            Wf.Created(WorkerName, Ct);
        }

        public void Run()
        {  
            var count = 0u;
            var partCount = Parts.Length;
            Wf.RunningT(WorkerName, new {PartCount = partCount}, Ct);
            
            foreach(var part in Parts)
            {
                try
                {                
                    count += Emit(part);            
                }
                catch(Exception e)
                {
                    Wf.Error(e,Ct);
                }
            }

            Wf.RanT(WorkerName, new {PartCount = partCount, RecordCount = count}, Ct);
        }
        
        static IPeMetaReader Reader(string src)
            => PeMetaReader.open(FilePath.Define(src));

        FilePath TargetPath(PartId part)
            => TargetDir +  FileName.Define(part.Format(), "fields.csv");

        uint Emit(IPart part)
        {
            var rk = ImageRecords.FieldRva;
            var id = part.Id;
            var path = TargetPath(id);

            Wf.Emitting(WorkerName, DatasetName, path, Ct);

            var assembly = part.Owner;                
            using var reader = Reader(assembly.Location);
            var src = reader.ReadFields();
            var count = src.Length;              

            var formatter = PartRecords.formatter(Spec);
            formatter.EmitHeader();
            foreach(var record in src)
                PartRecords.format(record, formatter);

            path.Ovewrite(formatter.Render());  
            Wf.Emitted(WorkerName, DatasetName, (uint)src.Length, path, Ct);
            return (uint)count;
        }


        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }
    }
}