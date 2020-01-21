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
    
    using static zfunc;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class CoreFunc : AssemblyDesignator<CoreFunc>
    {
        public override AssemblyId Id 
            => AssemblyId.CoreFunc;

        public override IOperationCatalog Catalog 
            => new Catalog();

    }

}