//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public abstract class ArtifactModel<B,F> : IArtifactModel
        where B : ArtifactModel<B,F>
        where F : unmanaged, Enum
    {
        public string Name {get;}

        protected ArtifactModel(string name, F facets)
        {
            this.Name = name;
            this.Facets = facets;
        }

        public F Facets {get;}
    }
}