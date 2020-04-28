//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using E = CaptureWorkflowEvents.HostFileEmissionFailed;

    partial class CaptureWorkflowEvents
    {
        public readonly struct HostFileEmissionFailed : IAppEvent<E>
        {
            public static E Empty => new E(ApiHostUri.Empty,false, FilePath.Empty);

            public readonly ApiHostUri Host;

            public readonly bool Generic;

            public readonly FilePath TargetFile;

            [MethodImpl(Inline)]
            public static E Define(ApiHostUri host, bool generic, FilePath dst)
                => new E(host,generic, dst);

            [MethodImpl(Inline)]
            HostFileEmissionFailed(ApiHostUri uri, bool generic, FilePath dst)
            {
                this.Host = uri;
                this.Generic = generic;
                this.TargetFile = dst;
            }
                        
            public string Description
                => $"{Host} emission failure" + (Generic ? " (generic)" : string.Empty) + TargetFile.FullPath;
            
            public HostFileEmissionFailed Zero => Empty;

        }            
    }
}