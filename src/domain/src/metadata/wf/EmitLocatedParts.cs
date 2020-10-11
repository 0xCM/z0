//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Diagnostics;

    using static Konst;

    using static z;

    [WfHost]
    public sealed class EmitLocatedPartsHost : WfHost<EmitLocatedPartsHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitLocatedParts(wf.WithHost(this), this);
            wf.Running();
            step.Run();
            wf.Ran();
        }
    }

    public ref struct EmitLocatedParts
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly Span<IPart> Parts;

        readonly LocatedImages Images;

        readonly FolderPath TargetDir;

        public Span<LocatedPart> Index;

        [MethodImpl(Inline)]
        public EmitLocatedParts(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Parts = Wf.Api.Parts;
            Index = default;
            TargetDir = wf.ResourceRoot + FolderName.Define("images");
            var process = Process.GetCurrentProcess();
            Images = process.Modules.Cast<ProcessModule>().Map(ProcessImages.locate).OrderBy(x => x.BaseAddress);
            wf.Created();

        }

        public void Dispose()
        {
             Wf.Disposed();
        }

        public void Run()
        {
             var count = Parts.Length;

             Index = span<LocatedPart>(count);
             for(var i=0u; i<count; i++)
             {
                ref readonly var part = ref skip(Parts, i);
                var @base = ProcessImages.@base(part);
                var dstpath = TargetDir + FileName.define(part.Format(), FileExtension.Define("csv"));

                EmitImageData.create().Run(Wf, part, out var offset);
                seek(Index,i) = new LocatedPart(part, @base, (uint)(offset - @base));
             }

            EmitImageSummariesHost.create(Images).Run(Wf);
        }
    }
}