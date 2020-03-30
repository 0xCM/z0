//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface ITypeArtifact : IArtifactModel
    {
        IEnumerable<ITypeArtifact> NestedTypes {get;}

        TypeFacets Facets {get;}

        IEnumerable<IMemberArtifact> Members {get;}
    }
}