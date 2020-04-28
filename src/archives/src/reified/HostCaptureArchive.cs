//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using static Z0.Seed;

    /// <summary>
    /// A host-specific capture archive
    /// </summary>
    public readonly struct HostCaptureArchive : IHostCaptureArchive
    {
        public ICaptureArchive Parent {get;}
                
        public ApiHostUri HostUri {get;}

        [MethodImpl(Inline)]
        public static IHostCaptureArchive Create(ICaptureArchive root, ApiHostUri host)
            => new HostCaptureArchive(root,host);

        public FolderPath[] Clear()
        {
            return Arrays.empty<FolderPath>();
        }

        public ICaptureArchive Narrow(FolderName area, FolderName subject)
            => Parent.Narrow(area, subject);

        [MethodImpl(Inline)]
        internal HostCaptureArchive(ICaptureArchive root, ApiHostUri host)
        {
            this.HostUri = host;
            this.Parent = root;
        }    
    }
}