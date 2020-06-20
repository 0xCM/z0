//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct StructArtifact : ITypeArtifact<StructArtifact,StructFacets>
    {
        public string Namespace {get;}

        public string Declarer {get;}

        public string Identifier {get;}

        public StructFacets Facets {get;}

        public string Description {get;}

        public MemberArtifact[] Members {get;}

        public TypeArtifact[] NestedTypes {get;}

        [MethodImpl(Inline)]
        public StructArtifact(string Namespace, string Identifier, StructFacets Facets, string Description, MemberArtifact[] Members)
        {
            this.Identifier = Identifier;
            this.Namespace = Namespace;
            this.Facets = Facets;
            this.Description = Description;
            this.Declarer = string.Empty;
            this.Members = Members;
            this.NestedTypes = Root.array<TypeArtifact>();
        }        

        [MethodImpl(Inline)]
        public StructArtifact(string Namespace, string Declarer, string Name, StructFacets Facets, string Description, MemberArtifact[] Members, TypeArtifact[] NestedTypes)
        {            
            this.Identifier = Name;
            this.Namespace = Namespace;
            this.Declarer = Declarer;
            this.Facets = Facets;
            this.Description = Description;
            this.Members = Members;
            this.NestedTypes = NestedTypes;
        }        
    }
}