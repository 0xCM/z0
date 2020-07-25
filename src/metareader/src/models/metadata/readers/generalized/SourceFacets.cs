//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct SourceFacets : ISourceFacets<SourceFacets>
    {
        public uint RowCount {get;}
        
        public uint RowSize {get;}
        
        public SourceFacets(uint rows, uint rowsize)
        {
            RowCount = rows;
            RowSize = rowsize;
        }    
    }

    public readonly struct SourceFacets<F> : ISourceFacets<SourceFacets<F>,SourceFacets>
        where F : struct, ISourceFacets
    {
        public F Facets {get;}

        public uint RowCount => Facets.RowCount;
        
        public uint RowSize => Facets.RowSize;
                
        public static implicit operator SourceFacets<F>(F src)
            => new SourceFacets<F>(src);
        
        public SourceFacets(F facets)
        {
            Facets = facets;
        }    
    }    
}