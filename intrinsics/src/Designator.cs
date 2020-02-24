//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;

    public sealed class Intrinsics : AssemblyResolution<Intrinsics>
    {        
        const AssemblyId Identity = AssemblyId.Intrinsics;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Operations 
            => new Catalog();
    }
}