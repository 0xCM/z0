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

    using static zfunc;
    using static AsmServiceMessages;

    class ArchiveControl : Controller<ArchiveControl>
    {                
        void Emit(AssemblyId id)
            => FindCatalog(id).OnSome(c => c.Emit()).OnNone(() => CatalogNotFound(id));
        
        void Emit(IEnumerable<AssemblyId> src)
            => iter(src, Emit);

        public override void Execute()
        {             
            Emit(AssemblyId.Intrinsics); 
            // Emit(AssemblyId.GMath);
            // Emit(AssemblyId.CoreFunc);
            // Emit(AssemblyId.BitCore);            
        }

    }
}