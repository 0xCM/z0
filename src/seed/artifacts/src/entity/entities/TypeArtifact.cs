//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 

    public readonly struct TypeArtifact : IArtifactModel<TypeArtifact,TypeFacets>
    {
        public string Namespace {get;}

        public string Declarer {get;}

        public string Identifier {get;}

        public TypeFacets Facets {get;}

        public string Description {get;}

        public MemberArtifact[] Members {get;}

        public TypeArtifact[] NestedTypes {get;}

        [MethodImpl(Inline)]
        public TypeArtifact(string Namespace, string Declarer, string Identifier, TypeFacets Facets, string Description,  MemberArtifact[] Members, TypeArtifact[] NestedTypes)
        {
            this.Namespace = Namespace;
            this.Declarer = Declarer;
            this.Identifier = Identifier;
            this.Facets = Facets;
            this.Description = Description;
            this.NestedTypes = NestedTypes;
            this.Members = Members;
        }
    }
}