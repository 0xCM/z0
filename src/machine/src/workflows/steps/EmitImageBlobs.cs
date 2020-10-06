//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using F = ImageBlobField;
    using W = ImageBlobFieldWidth;

    [WfHost]
    public sealed class EmitImageBlobs : WfHost<EmitImageBlobs>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitImageBlobsStep(wf,this);
            step.Run();
        }
    }

    ref struct EmitImageBlobsStep
    {
        const string DataType = "ImageBlob";

        public uint EmissionCount;

        readonly IWfShell Wf;

        readonly IPart[] Parts;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public EmitImageBlobsStep(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Parts = Wf.Api.Storage;
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
            var dstPath = Wf.Paths.Table("image.blobs", string.Concat(part.Id.Format(), "blob"));
            var data = Read(part);
            var count = (uint)data.Length;
            var target = sink();

            for(var i=0u; i<count; i++)
                target.Deposit(skip(data,i));

            using var writer = dstPath.Writer();
            writer.Write(target.Render());

            EmissionCount += count;

            Wf.EmittedTable<ImageBlob>(Host, count, dstPath);
        }

        public void Run()
        {
            Wf.Running(Host, DataType);

            foreach(var part in Parts)
                Emit(part);

            Wf.Ran(Host, delimit(DataType, EmissionCount));
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}