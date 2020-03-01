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
    public sealed class Fixed : AssemblyResolution<Fixed>
    {
        const AssemblyId Identity = AssemblyId.Fixed;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Operations 
            => new Catalog(Identity);
    }
}