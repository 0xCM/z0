//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using static zfunc;

    class Catalog : OpCatalog<Catalog>
    {
        public Catalog()
        {

        }
        
        public override IEnumerable<Type> GenericApiHosts
            => items(typeof(Converter), typeof(AsIn), typeof(As));
               
    }
}