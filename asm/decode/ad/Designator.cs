//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;

    public sealed class AsmDecode : AssemblyResolution<AsmDecode>
    {
        const AssemblyId Identity = AssemblyId.AsmDecode;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Operations 
            => new Catalog(Identity);
    }
}