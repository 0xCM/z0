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
            => typeof(BVTypes).GetNestedTypes().Realize<IFunc>();

        public override IEnumerable<Type> GenericApiHosts
            => items(typeof(BitVector));

        public override IEnumerable<Type> DirectApiHosts
            => items(typeof(BitVector));
               
        public override string CatalogName 
            => "bitvectors";
    }
}