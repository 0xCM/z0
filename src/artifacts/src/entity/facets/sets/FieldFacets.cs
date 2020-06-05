//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct FieldFacets  : IFacetSet<FieldFacets, FieldArtifact>
    {
        public readonly AccessFacetKind Access;

        public readonly ModifierFacetKind Modifier;
        
        [MethodImpl(Inline)]
        public FieldFacets(AccessFacetKind Access, ModifierFacetKind Modifier)
        {
            this.Access = Access;
            this.Modifier = Modifier;
        }        
    }
}