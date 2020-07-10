//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct StructFacets : IFacetSet<StructFacets, StructArtifact>
    {
        [MethodImpl(Inline)]
        public StructFacets(AccessFacetKind Access)
        {
            this.Access = Access;
        }
        
        public readonly AccessFacetKind Access;
    }
}