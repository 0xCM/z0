//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.CompilerServices;
    using Z0.AsmSpecs;

    using static zfunc;

    readonly struct AsmHostArchive : IAsmHostArchive
    {
        [MethodImpl(Inline)]
        public static IAsmHostArchive Create(IAsmContext context, ApiHostPath host)
            => new AsmHostArchive(context, host);

        [MethodImpl(Inline)]
        AsmHostArchive(IAsmContext context, ApiHostPath host)
        {
            this.Context = context;
            this.Host = host;
            this.ArchivedCode = new Archived<AsmCode>[]{};
        }
        
        public IAsmContext Context {get;}
        
        public ApiHostPath Host {get;}
        
        public IEnumerable<Archived<AsmCode>> ArchivedCode {get;}
    }
}
