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
        const string TableId = CliBlob.TableId;

        public uint EmissionCount;

        readonly IWfShell Wf;

        readonly IPart[] Parts;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public EmitImageBlobsStep(IWfShell wf, WfHost host)
        {
            Wf = wf.WithHost(host);
            Host = host;
            Parts = Wf.Api.Parts;
            EmissionCount = 0;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public ReadOnlySpan<CliBlob> Read(IPart part)
        {
            using var reader = PeTableReader.open(part.PartPath());
            return reader.Blobs();
        }

        static string format(in CliBlob src, ReadOnlySpan<TableColumn> columns, ITextBuffer dst)
        {
            dst.AppendDelimited(columns[0].Width, src.Seq);
            dst.AppendDelimited(columns[1].Width, src.HeapSize);
            dst.AppendDelimited(columns[2].Width, src.Offset);
            dst.AppendDelimited(columns[3].Width, src.Data);
            return dst.Emit();
        }

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[CliBlob.FieldCount]{12,12,12,30};

        void Emit(IPart part)
        {
            var dstPath = Wf.Db().Table(part.Id, TableId, FileExtensions.Csv);
            var data = Read(part);
            var count = (uint)data.Length;
            var buffer = Buffers.text();
            var columns = Table.columns(typeof(CliBlob), RenderWidths);
            var header = Table.header(columns);

            using var writer = dstPath.Writer();
            writer.WriteLine(header);

            for(var i=0u; i<count; i++)
                writer.WriteLine(format(skip(data,i), columns, buffer));

            EmissionCount += count;

            Wf.EmittedTable<CliBlob>(data.Length, dstPath);
        }

        public void Run()
        {
            Wf.Running();

            Wf.Db().Clear(FS.folder(TableId));
            foreach(var part in Parts)
                Emit(part);

            Wf.Ran();
        }
    }
}