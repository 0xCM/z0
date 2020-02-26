//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    public interface IAsmHostArchive : IAsmService
    {
        IEnumerable<Archived<AsmCode>> ArchivedCode {get;}        

    }

}