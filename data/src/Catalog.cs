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
        public Catalog(AssemblyId id)
            : base(id, DataResourceIndex.Create(Data.Resources))
        {

        }

        public override IEnumerable<ApiHost> DirectApiHosts
            => new ApiHost[]{ApiHost.Define(typeof(Data))};
        
    }
}