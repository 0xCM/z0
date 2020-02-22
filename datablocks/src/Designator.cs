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
    public sealed class DataBlocks : AssemblyDesignator<DataBlocks>
    {
        const AssemblyId Identity = AssemblyId.DataBlocks;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Catalog 
            => new Catalog(Identity);
    }
}