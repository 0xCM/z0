//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class AsmEvents
    {
        public readonly struct HostFileEmissionFailed : IAppEvent<HostFileEmissionFailed, ApiHostUri>
        {
            public ApiHostUri Payload {get;}

            public readonly bool Generic;

            public readonly FilePath TargetFile;

            public static HostFileEmissionFailed Empty => new HostFileEmissionFailed(ApiHostUri.Empty,false, FilePath.Empty);

            [MethodImpl(Inline)]
            public static HostFileEmissionFailed Define(ApiHostUri uri, bool generic, FilePath dst)
                => new HostFileEmissionFailed(uri,generic, dst);

            [MethodImpl(Inline)]
            HostFileEmissionFailed(ApiHostUri uri, bool generic, FilePath dst)
            {
                this.Payload = uri;
                this.Generic = generic;
                this.TargetFile = dst;
            }
                        
            public string Description
                => $"{Payload} emission failure" + (Generic ? " (generic)" : string.Empty) + TargetFile.FullPath;
            
            public HostFileEmissionFailed Zero => Empty;

        }            
    }
}