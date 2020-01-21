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
        void Emit(AssemblyId id, bool pll)
            => FindCatalog(id).OnSome(c => c.Emit(pll)).OnNone(() => CatalogNotFound(id));
        
        void Emit(IEnumerable<AssemblyId> src, bool pll)
            => iter(src, id => Emit(id,pll));

        public override void Execute()
        {             
            var pll = false;
            Emit(AssemblyId.Intrinsics, pll); 
            Emit(AssemblyId.GMath, pll);
            Emit(AssemblyId.CoreFunc, pll);
            Emit(AssemblyId.BitCore, pll);    
        }

    }
}