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

    using static Reflective;
    
    public interface ITypeArtifact : IArtifactModel
    {
        IEnumerable<ITypeArtifact> NestedTypes {get;}

        TypeFacets Facets {get;}

        IEnumerable<IMemberArtifact> Members {get;}
    }

    public interface IMemberArtifact : IArtifactModel
    {
        MemberFacets Facets {get;}
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

    public abstract class MemberArtifact<B,F> : ArtifactModel<B,F>, IMemberArtifact
        where F : unmanaged, Enum
        where B : MemberArtifact<B,F>
    {
        protected MemberArtifact(string name, F facets)
            : base(name,facets)
        {

        }

        MemberFacets IMemberArtifact.Facets 
            => (MemberFacets)(object)Facets;
    }
    
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

        TypeFacets ITypeArtifact.Facets 
            => (TypeFacets)(object)Facets;

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