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
    public sealed class BitCore : AssemblyDesignator<BitCore>
    {
        public override AssemblyId Id 
            => AssemblyId.BitCore;

        public override IOperationCatalog Catalog 
            => new Catalog();
    }
}