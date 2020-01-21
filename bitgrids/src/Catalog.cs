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
        public Catalog()
        {

        }
        
        public override IEnumerable<Type> ServiceHosts
            => array<Type>();

        public override IEnumerable<Type> GenericApiHosts
            => items(typeof(BitMatrix), typeof(BitGrid));

        public override IEnumerable<Type> DirectApiHosts
            => array<Type>();
               
        public override string CatalogName 
            => "bitgrids";
    }
}