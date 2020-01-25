//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Specialized;

    using AsmSpecs;

    public interface IAsmCatalogEmitter
    {
       IEnumerable<AsmFileDescriptor> EmitCatalog();
       
       IEnumerable<AsmFileDescriptor> EmitDirect();
       
       IEnumerable<AsmFileDescriptor> EmitGeneric();         
    }
}