//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct TypeFacets  : IFacetSet<TypeFacets, TypeArtifact>
    {
        [MethodImpl(Inline)]
        public TypeFacets(AccessFacetKind Access)
        {
            this.Access = Access;
        }
        
        public readonly AccessFacetKind Access;
    }
}