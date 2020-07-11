//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// A host-specific capture archive
    /// </summary>
    public readonly struct HostCaptureArchive : THostCaptureArchive
    {                      
        public static THostCaptureArchive Create(FolderPath root, ApiHostUri host)
            => new HostCaptureArchive(root, host);

        public ApiHostUri Host {get;}

        public FolderPath ArchiveRoot {get;}

        public FolderPath[] Clear(params PartId[] parts)
        {
            return Arrays.empty<FolderPath>();
        }

        [MethodImpl(Inline)]
        public HostCaptureArchive(FolderPath root, ApiHostUri host)
        {
            Host = host;
            ArchiveRoot = root;
        }    
    }
}