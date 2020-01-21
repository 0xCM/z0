//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
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
        
        public override IEnumerable<Type> GenericApiHosts
            => items(typeof(BitMatrixOpApi), typeof(BitVectorOpApi), typeof(ScalarOpApi), typeof(VectorizedOpApi));

        public override IEnumerable<Type> DirectApiHosts
            => items(typeof(math), typeof(fmath));
               
        public override string CatalogName 
            => nameof(gmath);
    }
}