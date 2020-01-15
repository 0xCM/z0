//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Reflection;

    using static zfunc;

    public interface ICatalogProvider
    {
        IOperationCatalog Catalog {get;}
    }

    public interface IOperationCatalog
    {
        IEnumerable<ContractedOpInfo> Contracted {get;} 

        IEnumerable<GenericOpInfo> Generic {get;}   
                    

        IEnumerable<DirectOpInfo> Direct {get;}       
        

        Assembly DeclaringAssembly {get;}         

        string Name {get;}
    }
}