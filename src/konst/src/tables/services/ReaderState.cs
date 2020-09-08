//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ReaderState<S>
        where S : struct, ISourceFacets
    {
        public S Facets {get;}

        public BinaryCode Source {get;}

        [MethodImpl(Inline)]
        public ReaderState(BinaryCode source, S facets)
        {
            Source = source;
            Facets = facets;
        }
    }
}