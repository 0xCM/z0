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

    public ref struct EmitImageSummaries
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly LocatedImages Images;

        readonly FS.FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmitImageSummaries(IWfShell wf, WfHost host, LocatedImages src)
        {
            Wf = wf;
            Host = host;
            Images = src;
            TargetPath = FS.path((Wf.IndexRoot + FileName.define("machine.images", FileExtensions.Csv)).Name);
            Wf.Created(Host);
        }

        public void Run()
        {
            ProcessImages.summarize(Images, TargetPath);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}