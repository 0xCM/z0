//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;

    using D = Z0.Designators;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class BitVectors : AssemblyDesignator<BitVectors>, ICatalogProvider
    {
        public IOperationCatalog Catalog 
            => new Catalog();


        public override AssemblyId Id 
            => AssemblyId.BitVectors;
    }

}

