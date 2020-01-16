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

    class Catalog : FastOpCatalog<Catalog>
    {
        public Catalog()
        {

        }
        
        public override IEnumerable<Type> ServiceHosts
            => typeof(GXTypes).GetNestedTypes().Realize<IFunc>();

        public override IEnumerable<Type> GenericApiHosts
            => items(typeof(gmath));

        public override IEnumerable<Type> DirectApiHosts
            => items(typeof(math), typeof(fmath));
               
        public override string CatalogName 
            => nameof(gmath);
    }
}