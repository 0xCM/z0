//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = ImageFieldTableField;
    using W = ImageFieldTabledWidth;

    public readonly ref struct EmitFieldMetadata
    {
        readonly IWfShell Wf;

        readonly IWfHost Host;

        readonly IPart[] Parts;

        readonly ImageFieldTable Spec;

        readonly FolderPath TargetDir;

        [MethodImpl(Inline)]
        public EmitFieldMetadata(IWfShell wf, EmitFieldMetadataHost host)
        {
            Wf = wf;
            Host = host;
            Parts = wf.Api.Parts;
            Spec = ImageRecords.Fields;
            TargetDir = wf.ResourceRoot + FolderName.Define("fields");
            Wf.Created(Host.Id);
        }

        public void Run()
        {
            var count = 0u;
            var partCount = Parts.Length;
            Wf.Running(Host.Id, new {PartCount = partCount});

            foreach(var part in Parts)
            {
                try
                {
                    count += Emit(part);
                }
                catch(Exception e)
                {
                    Wf.Error(Host.Id,e);
                }
            }

            Wf.Ran(Host.Id, new {PartCount = partCount, RecordCount = count});
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

            Wf.Emitting<ImageFieldTable>(Host.Id, FS.path(path.Name));

            var assembly = part.Owner;
            using var reader = Reader(assembly.Location);
            var src = reader.ReadFields();
            var count = (uint)src.Length;

            var formatter = Table.formatter<F,W>();
            formatter.EmitHeader(true);
            foreach(var record in src)
                format(record, formatter);

            path.Overwrite(formatter.Render());

            Wf.Emitted<ImageFieldTable>(Host.Id, count, FS.path(path.Name));
            return count;
        }

        static ref readonly RecordFormatter<F,W> format(in ImageFieldTable src, in RecordFormatter<F,W> dst, bool eol = true)
        {
            dst.Delimit(F.Sequence, src.Seq);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Signature, src.Sig);
            dst.Delimit(F.Attributes, src.Attribs);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }


        public void Dispose()
        {
            Wf.Disposed(Host.Id);
        }
    }
}