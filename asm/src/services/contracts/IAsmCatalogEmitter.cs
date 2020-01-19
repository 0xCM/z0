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
       void EmitCatalog();
       
       void EmitDirect();
       
       void EmitGeneric();
         
    }

}