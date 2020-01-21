//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class BitVectors : AssemblyDesignator<BitVectors>, ICatalogProvider
    {
        public override AssemblyId Id 
            => AssemblyId.BitVectors;

        public override IOperationCatalog Catalog 
            => new Catalog();
    }
}

