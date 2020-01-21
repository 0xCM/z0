//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using static zfunc;

    class Catalog : OpCatalog<Catalog>
    {
        public override IEnumerable<Type> DirectApiHosts
            => items(typeof(libm));
               
        public override string CatalogName 
            => nameof(libm);
    }
}