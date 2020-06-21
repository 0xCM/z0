//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IMemberArtifact : IArtifactModel
    {        
    }    

    public interface IMemberArtifact<M,F> : IMemberArtifact, IArtifactModel<F>
        where M : IMemberArtifact<M,F>, new()
        where F : unmanaged, IFacetSet
    {

    }
}