//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    
    using static zfunc;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class CoreFunc : AssemblyResolution<CoreFunc>
    {
        const AssemblyId Identity = AssemblyId.CoreFunc;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Operations 
            => new Catalog(Identity);
    }
}