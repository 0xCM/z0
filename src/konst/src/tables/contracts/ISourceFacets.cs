//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
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