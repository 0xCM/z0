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

    using F = CliBlobRecord.Fields;
    using W = CliBlobRecord.RenderWidths;

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
        const string DataType = CliBlobRecord.DataType;

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

        public ReadOnlySpan<CliBlobRecord> Read(IPart part)
        {
            using var reader = PeTableReader.open(part.PartPath());
            return reader.Blobs();
        }

        static string format(in CliBlobRecord src, RecordFormatter<F,W> dst)
        {
            dst.Delimit(F.Sequence, src.Seq);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Data);
            return dst.Render();
        }

        void Emit(IPart part)
        {
            var dstPath = Wf.Paths.Table(CliBlobRecord.TableId, string.Concat(part.Id.Format(), Chars.Dot, DataType));
            var data = Read(part);
            var count = (uint)data.Length;
            var formatter = Table.formatter<F,W>();

            using var writer = dstPath.Writer();
            writer.WriteLine(formatter.FormatHeader());

            for(var i=0u; i<count; i++)
                writer.WriteLine(format(skip(data,i),formatter));

            EmissionCount += count;

            Wf.EmittedTable<CliBlobRecord>(Host, data.Length, dstPath);
        }

        public void Run()
        {
            Wf.Running(Host, DataType);

            Wf.Db().Clear(FS.folder(CliBlobRecord.TableId));
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