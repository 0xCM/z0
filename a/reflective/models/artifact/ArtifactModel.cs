//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    public interface IArtifactModel
    {
        string Name {get;}
    }

    public interface ITypeArtifact : IArtifactModel
    {
        IEnumerable<ITypeArtifact> NestedTypes {get;}

        IEnumerable<IMemberArtifact> Members {get;}
    }

    public interface IMemberArtifact : IArtifactModel
    {
        
    }    
    
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