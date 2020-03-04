//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    using System;
    
    using Z0.Logix;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class Logix : AssemblyResolution<Logix>
    {
        const AssemblyId Identity = AssemblyId.Logix;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Operations 
            => new Catalog(Identity);
    }
}