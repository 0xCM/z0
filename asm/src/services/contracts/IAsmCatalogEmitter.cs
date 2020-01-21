//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;

    public interface IAsmCatalogEmitter
    {
       void EmitCatalog(bool pll);
       
       void EmitDirect(bool pll);
       
       void EmitGeneric(bool pll);
         
    }

}