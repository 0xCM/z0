//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct ApiHostArchive : IApiHostArchive
    {
        public IApiCodeArchive Parent {get;}
                
        public ApiHostUri HostUri {get;}

        [MethodImpl(Inline)]
        public static IApiHostArchive Define(IApiCodeArchive root, in ApiHostUri host)
            => new ApiHostArchive(root,host);

        [MethodImpl(Inline)]
        ApiHostArchive(IApiCodeArchive root, in ApiHostUri host)
        {
            this.HostUri = host;
            this.Parent = root;
        }    
    }
}