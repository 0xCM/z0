//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ReaderState<S> : IReaderState<S>
        where S : struct, ISourceFacets
    {
        public S Facets {get;}

        public BinaryCode Source {get;}
        
        public ReaderState(BinaryCode source, S facets)
        {
            Source = source;
            Facets = facets;
        }
    }
}