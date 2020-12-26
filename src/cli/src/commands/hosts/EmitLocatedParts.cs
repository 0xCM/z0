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
            wf.Running();
            step.Run();
            wf.Ran();
        }
    }

    ref struct EmitLocatedPartsStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly Span<IPart> Parts;

        readonly LocatedImageIndex Images;

        readonly FolderPath TargetDir;

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
                var dstpath = TargetDir + FileName.define(part.Format(), FileExtension.Define("csv"));

                using var step = new EmitPartImageData(Wf, part);
                step.Run();
                seek(Index,i) = new LocatedPart(part, @base, (uint)(step.OffsetAddress - @base));
             }

            EmitImageSummaries.create(Images).Run(Wf);
        }
    }
}