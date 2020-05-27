//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IArtifactModel
    {
        string Declarer => String.Empty;

        string Identifier {get;}
    }

    public interface IArtifactModel<F> : IArtifactModel
        where F : unmanaged, IFacetSet
    {
        F Facets {get;}
    }

    public interface IArtifactModel<M,F> : IArtifactModel<F>
        where M : IArtifactModel<M,F>, new()
        where F : unmanaged, IFacetSet
    {

    }
}