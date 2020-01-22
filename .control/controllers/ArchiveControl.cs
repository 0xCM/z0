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
    using static ControlMessages;
    

    class ArchiveControl : Controller<ArchiveControl>
    {                
        IOperationCatalog CheckCatalog(IOperationCatalog catalog)
        {
            if(catalog.IsEmpty)
                print(CatalogEmpty(catalog));
            else
                print(EmittingCatalog(catalog));
            return catalog;
        }

        void Emit(AssemblyId id)
            => FindCatalog(id).OnSome(c => CheckCatalog(c).Emit()).OnNone(() => CatalogNotFound(id));
        

        public override void Execute()
        {             
            print(EmittingAsmArchives());
            //Emit(AssemblyId.Intrinsics); 
            // Emit(AssemblyId.GMath);
            // Emit(AssemblyId.CoreFunc);
            // Emit(AssemblyId.BitCore); 
            Emit(AssemblyId.Logix);
        }

    }
}