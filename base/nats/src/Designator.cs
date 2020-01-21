//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class TypeNats : AssemblyDesignator<TypeNats>
    {
        public override AssemblyId Id 
            => AssemblyId.TypeNats;

        public override IOperationCatalog Catalog 
            => new Catalog();
    }
}