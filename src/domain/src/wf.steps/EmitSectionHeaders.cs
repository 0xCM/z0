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

    using F = ImageSectionHeader.Fields;
    using static ImageSectionHeader;

    [WfHost]
    public sealed class EmitSectionHeaders : WfHost<EmitSectionHeaders>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitSectionHeadersStep(wf.WithHost(this), this);
            step.Run();
        }
    }

    readonly ref struct EmitSectionHeadersStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IPart[] Parts;

        [MethodImpl(Inline)]
        public EmitSectionHeadersStep(IWfShell wf, WfHost host)
        {
            Wf = wf.WithHost(host);
            Host = host;
            Parts = Wf.Api.Parts;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }



        static void format(in ImageSectionHeader src, DatasetFormatter<Fields> dst)
        {
            dst.Delimit(Fields.FileName, src.File);
            dst.Delimit(Fields.Section, src.SectionName);
            dst.Delimit(Fields.Address, src.RawData);
            dst.Delimit(Fields.Size, src.RawDataSize);
            dst.Delimit(Fields.EntryPoint, src.EntryPoint);
            dst.Delimit(Fields.CodeBase, src.CodeBase);
            dst.Delimit(Fields.Gpt, src.GptRva);
            dst.Delimit(Fields.GptSize, src.GptSize);
        }

        public void Run()
        {
            using var flow = Wf.Running();

            var pCount = Parts.Length;
            var total = 0u;
            var formatter = Formatters.dataset<F>();
            var dst = Wf.Db().Table(ImageSectionHeader.TableId);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.HeaderText);

            foreach(var part in Parts)
            {
                var id = part.Id;
                var assembly = part.Owner;
                var records = PeTableReader.headers(FS.path(assembly.Location));
                var count = (uint)records.Length;

                for(var i=0; i<count; i++)
                {
                    format(skip(records,i), formatter);
                    writer.WriteLine(formatter.Render());
                }
                total += count;
            }

            Wf.EmittedTable<ImageSectionHeader>(total, dst);
        }
    }
}