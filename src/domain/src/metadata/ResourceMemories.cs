//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    public ref struct ResourceMemories
    {
        public readonly FS.FilePath SourcePath;

        readonly IWfShell Wf;

        readonly CliMemoryReader ClrReader;

        readonly WfHost Host;

        readonly ReadOnlySpan<CliManifestResourceInfo> Resources;

        public ResourceMemories(IWfShell wf, FS.FilePath src)
        {
            Wf = wf;
            SourcePath = src;
            ClrReader = CliMemoryReader.create(wf,src);
            Host = WfSelfHost.create(typeof(ResourceMemories));
            Resources = ClrReader.ManifestResourceDescriptions();
        }

        public void Dispose()
        {
            ClrReader.Dispose();
        }
    }
}