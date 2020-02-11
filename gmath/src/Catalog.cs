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
        public Catalog(AssemblyId id)
            : base(id)
        {

        }
        
        public override IEnumerable<Type> ServiceHosts
            => typeof(GXTypes).GetNestedTypes().Realize<IFunc>();

        public override IEnumerable<ApiHost> GenericApiHosts
            => from t in items(typeof(gmath), typeof(mathspan), typeof(gfp))
                select ApiHost.Define(AssemblyId,t);

        public override IEnumerable<ApiHost> DirectApiHosts
            => from t in items(typeof(math), typeof(fmath))
                select ApiHost.Define(AssemblyId,t);
    }
}