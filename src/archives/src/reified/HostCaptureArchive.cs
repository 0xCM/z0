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
        public static IHostCaptureArchive Define(ICaptureArchive root, in ApiHostUri host)
            => new HostCaptureArchive(root,host);

        public ICaptureArchive Clear()
        {
            return this;
        }

        public ICaptureArchive Narrow(FolderName area, FolderName subject)
            => Parent.Narrow(area, subject);

        [MethodImpl(Inline)]
        HostCaptureArchive(ICaptureArchive root, in ApiHostUri host)
        {
            this.HostUri = host;
            this.Parent = root;
        }    
    }
}