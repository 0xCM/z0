//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public interface IFacet
    {   
        string FacetName {get;}

        object FacetValue {get;}
    }

    public interface IFacet<T> : IFacet
    {   
        new T FacetValue {get;}

        object IFacet.FacetValue => FacetValue;
    }
}
