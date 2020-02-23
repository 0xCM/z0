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
        
        public override IEnumerable<Type> ServiceHostTypes
            => typeof(BCTypes).GetNestedTypes().Realize<IFunc>();

        // public override IEnumerable<ApiHost> GenericApiHosts
        //     => items(ApiHost.Define(AssemblyId,typeof(gbits)));

        // public override IEnumerable<ApiHost> DirectApiHosts
        //     => items(ApiHost.Define(AssemblyId,typeof(Bits)));
    }
}