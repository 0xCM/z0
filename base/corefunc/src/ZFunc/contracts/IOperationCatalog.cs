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
        IEnumerable<FastOpContract> Services {get;} 

        IEnumerable<FastGenericOp> GenericOps {get;}                       

        IEnumerable<FastDirectOp> DirectOps {get;}       

        IEnumerable<Type> ServiceHosts {get;}
        
        IEnumerable<Type> GenericApiHosts {get;}

        IEnumerable<Type> DirectApiHosts {get;}
        
        Assembly DeclaringAssembly {get;}         

        string CatalogName {get;}
    }
}