//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static zfunc;
    using static ginx;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class Intrinsics : AssemblyDesignator<Intrinsics>, ICatalogProvider
    {
            
        public IOperationCatalog Catalog 
            => VX.Catalog;

        public override AssemblyId Id 
            => AssemblyId.Intrinsics;
    }

}