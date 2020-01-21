//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;
    
    using Z0.Logix;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class Logix : AssemblyDesignator<Logix>
    {
        public override AssemblyId Id 
            => AssemblyId.Logix;

        public override IOperationCatalog Catalog 
            => new Catalog();
    }
}