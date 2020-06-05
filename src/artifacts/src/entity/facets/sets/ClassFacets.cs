//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct ClassFacets : IFacetSet<ClassFacets, ClassArtifact>
    {
        [MethodImpl(Inline)]
        public ClassFacets(AccessFacetKind Access)
        {
            this.Access = Access;
        }
        
        public readonly AccessFacetKind Access;
    }
}