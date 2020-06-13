//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFaceted
    {
        Facet Facet {get;}

    }

    public interface IFaceted<T> : IFaceted        
    {

        new Facet<T> Facet {get;}

        Facet IFaceted.Facet => Facet;
    }
}