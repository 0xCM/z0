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
    public sealed class BitCore : AssemblyResolution<BitCore>
    {
        const AssemblyId Identity = AssemblyId.BitCore;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Operations 
            => new Catalog(Identity);
    }
}