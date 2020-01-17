//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public static class AsmServices
    {
        
        public static IAsmCatalogEmitter CatalogEmitter(IOperationCatalog catalog)
            => new AsmCatalogEmitter(catalog);

    }

}