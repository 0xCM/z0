//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class MemberArtifact<B,F> : ArtifactModel<B,F>, IMemberArtifact
        where F : unmanaged, Enum
        where B : MemberArtifact<B,F>
    {
        protected MemberArtifact(string name, F facets)
            : base(name,facets)
        {

        }
    }
}