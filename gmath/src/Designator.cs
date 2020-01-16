//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class GMath : AssemblyDesignator<GMath>, ICatalogProvider
    {
        public IOperationCatalog Catalog 
            => GX.Catalog;
    }
}