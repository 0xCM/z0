//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using AsmSpecs;

    public interface IAsmCatalogEmitter : IAsmService
    {
        IEnumerable<AsmEmissionToken> EmitPrimary();          

        IEnumerable<AsmEmissionToken> EmitImm();  

        IEnumerable<AsmEmissionToken> EmitCatalog()
            => EmitPrimary().Union(EmitImm());      
    }
}