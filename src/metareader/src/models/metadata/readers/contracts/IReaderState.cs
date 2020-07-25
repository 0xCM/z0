//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IReaderState
    {
        BinaryCode Source {get;}
    }

    public interface IReaderState<S> : IReaderState
        where S : struct, ISourceFacets
    {
        S Facets {get;}        
    }
}