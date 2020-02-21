//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    
    using static Root;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class DataCore : AssemblyDesignator<DataCore>
    {
        const AssemblyId Identity = AssemblyId.DataCore;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Catalog 
            => new Catalog(Identity);
    }
}