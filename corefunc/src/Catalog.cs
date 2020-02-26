//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static zfunc;

    class Catalog : OpCatalog<Catalog>
    {
        public Catalog(AssemblyId id)
            : base(id)
        {

        }
        
        public override IEnumerable<ApiHost> GenericApiHosts
            => from t in items(typeof(Cast))
                select ApiHost.Define(OwnerId, t);
               
    }
}