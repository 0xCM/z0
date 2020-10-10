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

        readonly FS.FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmitSectionHeadersStep(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Parts = Wf.Api.Storage;
            TargetPath = wf.Db().Table(ImageSectionHeader.TableId, "headers");
            Wf.Created(Host, TargetPath);
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            var pCount = Parts.Length;
            var total = 0u;
            Wf.Running(pCount);

            var formatter = Formatters.dataset<F>();
            using var writer = TargetPath.Writer();
            writer.WriteLine(formatter.HeaderText);

            foreach(var part in Parts)
            {
                var id = part.Id;
                var assembly = part.Owner;
                var records = PeTableReader.headers(FilePath.Define(assembly.Location));
                var count = (uint)records.Length;

                for(var i=0; i<count; i++)
                {
                    ImageSectionHeader.format(z.skip(records,i), formatter);
                    writer.WriteLine(formatter.Render());
                }
                total += count;
            }

            Wf.Ran(Host, delimit(pCount, total));
        }


    }
}