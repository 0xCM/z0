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
    public sealed class Analogs : AssemblyDesignator<Analogs>
    {
        const AssemblyId Identity = AssemblyId.Analogs;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Catalog 
            => new Catalog(Identity);
    }
}