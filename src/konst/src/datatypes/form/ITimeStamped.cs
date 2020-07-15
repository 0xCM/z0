//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITimeStamped : IFacet<DateTime>
    {
        DateTime Timestamp {get;}

        string IFacet.FacetName 
            => nameof(Timestamp);

        DateTime IFacet<DateTime>.FacetValue 
            => Timestamp;
    }
}