//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    class Catalog : OpCatalog<Catalog>
    {
        public Catalog(AssemblyId id)
            : base(id)
        {

        }
        
        public override IEnumerable<ApiHost> GenericApiHosts
            => from t in items(typeof(BitMatrix), typeof(BitGrid))
                select ApiHost.Define(OwnerId, t);

        public override IEnumerable<ApiHost> DirectApiHosts
            => from t in items(typeof(BitMatrix), typeof(BitGrid))
                select ApiHost.Define(OwnerId, t);
    }
}