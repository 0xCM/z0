//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFacetSet
    {
        
    }

    public interface IFacetSet<F,A> : IFacetSet
        where F : unmanaged, IFacetSet<F,A>
        where A : IArtifactModel
    {

    }
}