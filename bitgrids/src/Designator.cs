//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    using System;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class BitGrids : AssemblyResolution<BitGrids>
    {
        const AssemblyId Identity = AssemblyId.BitGrids;

        public override AssemblyId Id 
            => Identity;
        
        public override IOperationCatalog Operations 
            => new Catalog(Identity);        
    }
}