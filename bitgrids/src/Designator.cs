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
    public sealed class BitGrids : AssemblyDesignator<BitGrids>
    {
        const AssemblyId Identity = AssemblyId.BitGrids;

        public override AssemblyId Id 
            => Identity;
        
        public override IOperationCatalog Catalog 
            => new Catalog(Identity);        
    }
}