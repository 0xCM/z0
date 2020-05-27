//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct EnumFacets : IFacetSet<EnumFacets, EnumEntity>
    {
        public readonly NumericFacetKind NumericBase;

        public readonly AccessFacetKind Access;
        
        [MethodImpl(Inline)]
        public EnumFacets(AccessFacetKind Access, NumericFacetKind NumericBase)
        {
            this.Access = Access;
            this.NumericBase = NumericBase;
        }
    }
}