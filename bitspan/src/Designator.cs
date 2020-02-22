//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;

    public sealed class BitSpan : AssemblyDesignator<BitSpan>
    {
        const AssemblyId Identity = AssemblyId.BitSpanTest;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Catalog 
            => new Catalog(Identity);
    }
}