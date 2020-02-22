//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    

    class Catalog : OpCatalog<Catalog>
    {
        public Catalog(AssemblyId id)
            : base(id)
        {

        }

        public override IEnumerable<ApiHost> DirectApiHosts
            => from t in (new Type[]{typeof(Numeric),typeof(SpanOps)})
                select ApiHost.Define(AssemblyId,t);

        public override IEnumerable<ApiHost> GenericApiHosts
            => from t in (new Type[]{typeof(Numeric),typeof(SpanOps),typeof(Refs),typeof(AsIn), typeof(As)})
                select ApiHost.Define(AssemblyId,t);

    }
}