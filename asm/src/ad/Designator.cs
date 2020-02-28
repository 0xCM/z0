//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;

    public sealed class Asm : AssemblyResolution<Asm>
    {
        const AssemblyId Identity = AssemblyId.Asm;        

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Operations 
            => new Catalog(Identity);
    }
}