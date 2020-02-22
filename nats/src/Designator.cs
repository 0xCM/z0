//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.IO;
    
    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class Nats : AssemblyDesignator<Nats>
    {
        const AssemblyId Identity = AssemblyId.Nats;


        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Catalog 
            => new Catalog(Identity);
    }
}