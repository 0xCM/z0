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
    public sealed class EmitLocatedParts : WfHost<EmitLocatedParts>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitLocatedPartsStep(wf.WithHost(this), this);
            var flow = wf.Running();
            step.Run();
            wf.Ran(flow);
        }
    }

    ref struct EmitLocatedPartsStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly Span<IPart> Parts;

        readonly LocatedImageIndex Images;

        readonly FS.FolderPath TargetDir;

        public Span<LocatedPart> Index;

        [MethodImpl(Inline)]
        public EmitLocatedPartsStep(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Parts = Wf.Api.Parts;
            Index = default;
            TargetDir = wf.ResourceRoot + FS.folder("images");
            Images = ImageMaps.current();
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
                var @base = ImageMaps.@base(part);
                using var step = new EmitPartImageData(Wf, part);
                step.Run();
                seek(Index,i) = new LocatedPart(part, @base, (uint)(step.OffsetAddress - @base));
             }

             ImageMaps.emit(Images, TargetDir + FS.file("imagemaps", FileExtension.Define("csv")));
        }
    }
}