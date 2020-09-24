//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly ref struct EmitFieldMetadata
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IPart[] Parts;

        readonly FolderPath TargetDir;

        [MethodImpl(Inline)]
        public EmitFieldMetadata(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Parts = wf.Api.Parts;
            TargetDir = wf.ResourceRoot + FolderName.Define("fields");
            Wf.Created(Host);
        }

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

        static ReadOnlySpan<byte> Widths => new byte[7]{16,60,12,12,16,40,30};

        uint Emit(IPart part)
        {
            var t = new ImageFieldTable();
            var file = FS.file(string.Format("{0}.{1}", part.Id.Format(), ImageFieldTable.TableName), ArchiveExt.Csv);
            var path = FS.dir(TargetDir.Name) +  file;
            Wf.Emitting(Host, t, FS.path(path.Name));

            var assembly = part.Owner;
            using var reader = PeTableReader.open(FilePath.Define(assembly.Location));
            var src = reader.ReadFields();
            var count = (uint)src.Length;

            var formatter = Table.rowformatter(Widths,t);
            using var writer = path.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var item in src)
                writer.WriteLine(formatter.FormatRow(item));

            Wf.Emitted(Host, t, count, FS.path(path.Name));
            return count;
        }

        public void Dispose()
        {
            Wf.Disposed(Host.Id);
        }
    }
}