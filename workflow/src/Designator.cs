//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;

    public sealed class Workflow : AssemblyDesignator<Workflow>
    {
        const AssemblyId Identity = AssemblyId.Workflow;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Catalog 
            => new Catalog(Identity);
    }
}