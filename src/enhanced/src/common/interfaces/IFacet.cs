//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IFacet
    {   
        string FacetName {get;}

        object FacetValue {get;}
    }

    public interface IFacet<V> : IFacet
    {   
        new V FacetValue {get;}

        object IFacet.FacetValue 
            => FacetValue;
    }
}