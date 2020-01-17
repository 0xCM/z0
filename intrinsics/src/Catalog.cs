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
        public override IEnumerable<Type> ServiceHosts
            => typeof(VXTypes).GetNestedTypes().Realize<IFunc>();

        public override IEnumerable<Type> GenericApiHosts
            => items(typeof(ginx),typeof(vblocks));

        public override IEnumerable<Type> DirectApiHosts
            => items(typeof(dinx));
               
        public override string CatalogName 
            => nameof(ginx);
    }
}