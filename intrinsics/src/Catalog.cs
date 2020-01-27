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
            : base(id)
        {

        }

        public override IEnumerable<Type> ServiceHosts
            => typeof(VXTypes).GetNestedTypes().Realize<IFunc>();

        public override IEnumerable<Type> GenericApiHosts
            => items(typeof(ginx),typeof(vblocks),typeof(VPattern));

        public override IEnumerable<Type> DirectApiHosts
            => items(typeof(dinx));               
    }
}