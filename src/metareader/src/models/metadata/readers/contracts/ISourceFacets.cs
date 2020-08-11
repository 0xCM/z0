//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface ISourceFacets
    {
        uint RowCount {get;}

        uint RowSize {get;}
    }
    
    public interface ISourceFacets<F> : ISourceFacets
        where F : struct
    {
 
    }    

    public interface ISourceFacets<S,F> : ISourceFacets<F>
        where S : struct, ISourceFacets<S,F>
        where F : struct
    {
    
    }    

}