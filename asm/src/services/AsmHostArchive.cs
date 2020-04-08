//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Core;

    readonly struct AsmHostArchive : IAsmHostArchive
    {        
        public ApiHostUri Host {get;}
        
        public IEnumerable<ArchivedContent<AsmCode>> ArchivedCode {get;}

        [MethodImpl(Inline)]
        public static IAsmHostArchive Create(IContext context, ApiHostUri host)
            => new AsmHostArchive(host);

        [MethodImpl(Inline)]
        AsmHostArchive(ApiHostUri host)
        {
            this.Host = host;
            this.ArchivedCode = new ArchivedContent<AsmCode>[]{};
        }       
    }
}