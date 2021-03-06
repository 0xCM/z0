//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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

        readonly FS.FolderPath TargetDir;

        [MethodImpl(Inline)]
        public EmitFieldMetadataStep(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Parts = wf.Api.Parts;
            TargetDir = wf.Db().TableDir("resources") + FS.folder("fields");
            Wf.Created();
        }

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[ClrFieldInfo.FieldCount]{16,60,12,12,16,40,30};

        public void Run()
        {
            var count = 0u;
            var flow = Wf.Running(Parts.Length);

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

            Wf.Ran(flow, count);
        }

        uint Emit(IPart part)
        {
            var target = Wf.Db().Table(ClrFieldInfo.TableId, part.Id);
            var flow = Wf.EmittingTable<ClrFieldInfo>(target);

            var assembly = part.Owner;
            using var reader = PeTableReader.open(FS.path(assembly.Location));
            var src = reader.Fields();
            var count = (uint)src.Length;

            var formatter = TableFormatter.row<ClrFieldInfo>(RenderWidths);
            using var writer = target.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var item in src)
                writer.WriteLine(formatter.FormatRow(item));

            Wf.EmittedTable(flow, src.Length);
            return count;
        }

        public void Dispose()
        {
            Wf.Disposed();
        }
    }
}