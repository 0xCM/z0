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
        
        public override IEnumerable<Type> ServiceHostTypes
            => array<Type>();

        public override IEnumerable<ApiHost> GenericApiHosts
            => array<ApiHost>();

        public override IEnumerable<ApiHost> DirectApiHosts
            => array<ApiHost>();
    }
}