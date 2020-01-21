//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;

    public sealed class Intrinsics : AssemblyDesignator<Intrinsics>
    {        
        public override AssemblyId Id 
            => AssemblyId.Intrinsics;

        public override IOperationCatalog Catalog 
            => new Catalog();
    }
}