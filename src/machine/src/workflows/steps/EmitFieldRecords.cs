//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitFieldMetadataStep;

    public readonly ref struct EmitFieldMetadata
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly IPart[] Parts;

        readonly ImageFieldTable Spec;

        readonly FolderPath TargetDir;

        [MethodImpl(Inline)]
        public EmitFieldMetadata(IWfShell wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            Spec = ImageRecords.Fields;
            TargetDir = wf.ResourceRoot + FolderName.Define("fields");
            Wf.Created(StepId);
        }

        public void Run()
        {
            var count = 0u;
            var partCount = Parts.Length;
            Wf.Running(StepId, new {PartCount = partCount});

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

            Wf.Ran(StepId, new {PartCount = partCount, RecordCount = count});
        }

        static IPeTableReader Reader(string src)
            => PeTableReader.open(FilePath.Define(src));

        FilePath TargetPath(PartId part)
            => TargetDir +  FileName.define(part.Format(), "fields.csv");

        uint Emit(IPart part)
        {
            var rk = ImageRecords.FieldRva;
            var id = part.Id;
            var path = TargetPath(id);

            Wf.Emitting(StepId, DatasetName, path);

            var assembly = part.Owner;
            using var reader = Reader(assembly.Location);
            var src = reader.ReadFields();
            var count = src.Length;

            var formatter = PartRecords.formatter(Spec);
            formatter.EmitHeader();
            foreach(var record in src)
                PartRecords.format(record, formatter);

            path.Overwrite(formatter.Render());
            Wf.Emitted(StepId, DatasetName, (uint)src.Length, path);
            return (uint)count;
        }


        public void Dispose()
        {
            Wf.Finished(StepId);
        }
    }
}