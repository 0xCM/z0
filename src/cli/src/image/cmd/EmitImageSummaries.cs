//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Linq;

    using static Part;

    [WfHost]
    public sealed class EmitImageSummaries : WfHost<EmitImageSummaries>
    {
        LocatedImageIndex Source;

        [MethodImpl(Inline)]
        public static WfHost create(LocatedImageIndex src)
        {
            var host = new EmitImageSummaries();
            host.Source = src;
            return host;
        }

        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitImageSummariesStep(wf,this,Source);
            step.Run();
        }
    }

    public ref struct EmitImageSummariesStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly LocatedImageIndex Images;

        readonly FS.FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmitImageSummariesStep(IWfShell wf, WfHost host, LocatedImageIndex src)
        {
            Wf = wf;
            Host = host;
            Images = src;
            TargetPath = Wf.ResourceRoot + FS.file("images", FileExtensions.Csv);
            Wf.Created(Host);
        }

        public void Run()
        {
            LocatedImages.emit(Images, TargetPath);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}