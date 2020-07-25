//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFaceted<F>
        where F : struct
    {
        F Facets {get;}

    }
    
    public interface IFaceted<S,F> : IFaceted<F>
        where S : struct, IFaceted<S,F>
        where F : struct
    {
        
    }
}