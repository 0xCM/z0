//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// A host-specific capture archive
    /// </summary>
    public readonly struct HostCaptureArchive : IHostCaptureArchive<HostCaptureArchive>
    {
        public ApiHostUri Host {get;}

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        internal HostCaptureArchive(FS.FolderPath root, ApiHostUri host)
        {
            Host = host;
            Root = root;
        }
    }
}