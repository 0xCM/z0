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
    public sealed class TypeNats : AssemblyDesignator<TypeNats>
    {
        const AssemblyId Identity = AssemblyId.TypeNats;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Catalog 
            => new Catalog(Identity);
    }
}