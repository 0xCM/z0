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
        public override AssemblyId Id 
            => AssemblyId.BitGrids;

        public override IOperationCatalog Catalog 
            => new Catalog();        
    }
}