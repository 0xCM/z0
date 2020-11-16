//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;


    [WfHost]
    public sealed class EmitFieldMetadata : WfHost<EmitFieldMetadata>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitFieldMetadataStep(wf, this);
            step.Run();
        }
    }

    readonly ref struct EmitFieldMetadataStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IPart[] Parts;

        readonly FolderPath TargetDir;

        [MethodImpl(Inline)]
        public EmitFieldMetadataStep(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Parts = wf.Api.Parts;
            TargetDir = wf.ResourceRoot + FolderName.Define("fields");
            Wf.Created(Host);
        }

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[CliField.FieldCount]{16,60,12,12,16,40,30};

        public void Run()
        {
            var count = 0u;
            Wf.Running(Host, Parts.Length);

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

            Wf.Ran(Host, count);
        }

        uint Emit(IPart part)
        {
            var t = new CliField();
            var path = Wf.Db().Table(CliField.TableId, part.Id);
            var assembly = part.Owner;
            using var reader = PeTableReader.open(FS.path(assembly.Location));
            var src = reader.Fields();
            var count = (uint)src.Length;

            var formatter = TableFormatter.row(RenderWidths, t);
            using var writer = path.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var item in src)
                writer.WriteLine(formatter.FormatRow(item));

            Wf.EmittedTable(Host, src.Length, FS.path(path.Name),t);
            return count;
        }

        public void Dispose()
        {
            Wf.Disposed(Host.Id);
        }
    }
}