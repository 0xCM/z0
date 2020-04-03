//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class TypeArtifact<B,F> : ArtifactModel<B,F>, ITypeArtifact
        where F : unmanaged, Enum
        where B : TypeArtifact<B,F>
    {
        protected TypeArtifact(string ns, string name, F facets)
            : base(name,facets)
        {
            this.Namespace = ns;
        }

        List<ITypeArtifact> types {get;}
            = new List<ITypeArtifact>();

        List<IMemberArtifact> members {get;}
            = new List<IMemberArtifact>();

        public IEnumerable<ITypeArtifact> NestedTypes
            => types;
        
        public string Namespace {get;}


        public IEnumerable<IMemberArtifact> Members 
            => members;

        public TypeArtifact<B,F> WithNestedTypes(IEnumerable<ITypeArtifact> src)
        {
            types.AddRange(src);
            return this;
        }

        public TypeArtifact<B,F> WithMembers(IEnumerable<IMemberArtifact> src)
        {
            members.AddRange(src);
            return this;
        }
    }
}