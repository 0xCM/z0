//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitImageBlobsHost;
    using static z;

    using F = ImageBlobField;
    using W = ImageBlobFieldWidth;

    public ref struct EmitImageBlobs
    {
        public uint EmissionCount;

        public readonly FolderPath TargetDir;

        readonly IWfShell Wf;

        readonly IPart[] Parts;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public EmitImageBlobs(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Parts = Wf.Api.Storage;
            TargetDir = wf.ResourceRoot + FolderName.Define("blobs");
            EmissionCount = 0;
            Wf.Created(Host);
        }

        public ReadOnlySpan<ImageBlob> Read(IPart part)
        {
            using var reader = PeTableReader.open(part.PartPath());
            return reader.ReadBlobs();
        }

        static DataSink<F,ImageBlob> sink()
        {
            var formatter = Table.formatter<F,W>();
            formatter.EmitHeader();
            return new DataSink<F,ImageBlob>(formatter, deposit);
        }

        static void deposit(in ImageBlob src, IDatasetFormatter<F> dst)
        {
            dst.Delimit(F.Sequence, src.Seq);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Data);
            dst.EmitEol();
        }

        void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath =  TargetDir + FileName.define(id.Format(), "blob.csv");

            Wf.Emitting<ImageBlob>(Host, FS.path(dstPath.Name));

            var data = Read(part);
            var count = (uint)data.Length;
            var target = sink();

            for(var i=0u; i<count; i++)
                target.Deposit(skip(data,i));

            using var writer = dstPath.Writer();
            writer.Write(target.Render());

            EmissionCount += count;

            Wf.Emitted<ImageBlob>(Host, count, FS.path(dstPath.Name));
        }

        public void Run()
        {
            Wf.Running(Host, delimit(EmissionType, TargetDir));

            foreach(var part in Parts)
                Emit(part);

            Wf.Ran(Host, delimit(EmissionType, EmissionCount, TargetDir));
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}