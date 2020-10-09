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

    using static ClrData;

    public interface IArchiveDoc<D,I,C> : IIdentified<I>, IContented<C>, ITextual
        where D : struct, IArchiveDoc<D,I,C>
    {

    }


    public struct CaptureArtifacts
    {


    }

    public sealed class WfSelfHost : WfHost<WfSelfHost>
    {
        Type HostType;

        public override WfStepId Id => HostType;

        public static WfSelfHost create(Type self)
        {
            var host = new WfSelfHost();
            host.HostType = self;
            return host;
        }
    }

    public ref struct CaptureResourceReader
    {
        public readonly FS.FilePath SourcePath;

        readonly IWfShell Wf;

        readonly ImageMemoryMap ClrReader;

        readonly WfHost Host;

        readonly ReadOnlySpan<ManifestResourceInfo> Resources;

        public CaptureResourceReader(IWfShell wf, FS.FilePath src)
        {
            Wf = wf;
            SourcePath = src;
            ClrReader = ImageMemoryMap.create(wf,src);
            Host = WfSelfHost.create(typeof(CaptureResourceReader));
            Resources = ClrReader.ManifestResources();
        }

        public void Dispose()
        {
            ClrReader.Dispose();
        }

    }

}