//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public interface IAsmCatalogEmitter
    {
       IEnumerable<AsmDescriptor> EmitCatalog();
       
       IEnumerable<AsmDescriptor> EmitDirect();
       
       IEnumerable<AsmDescriptor> EmitGeneric();         
    }
}