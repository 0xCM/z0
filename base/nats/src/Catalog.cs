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

    class Catalog : OpCatalog<Catalog>
    {
        public Catalog()
        {

        }
        
        public override IEnumerable<Type> GenericApiHosts
            => new Type[]{};
               
        public override string CatalogName 
            => "typenats";
    }
}