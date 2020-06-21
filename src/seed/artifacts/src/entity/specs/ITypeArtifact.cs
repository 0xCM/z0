//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ITypeArtifact<A,F> : IArtifactModel<A,F>
        where A : ITypeArtifact<A,F>, new()
        where F : unmanaged, IFacetSet
    {
        MemberArtifact[] Members {get;}
    }

    public interface ITypeArtifact<A,M,F> : IArtifactModel<A,F>
        where A : ITypeArtifact<A,M,F>, new()
        where F : unmanaged, IFacetSet
        where M : IMemberArtifact
    {

        M[] Members {get;}
    }
}