//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct StructEntity : ITypeArtifact<StructEntity,StructFacets>
    {
        public string Namespace {get;}

        public string Declarer {get;}

        public string Identifier {get;}

        public StructFacets Facets {get;}

        public string Description {get;}

        public MemberEntity[] Members {get;}

        public TypeEntity[] NestedTypes {get;}

        [MethodImpl(Inline)]
        public StructEntity(string Namespace, string Identifier, StructFacets Facets, string Description, MemberEntity[] Members)
        {
            this.Identifier = Identifier;
            this.Namespace = Namespace;
            this.Facets = Facets;
            this.Description = Description;
            this.Declarer = string.Empty;
            this.Members = Members;
            this.NestedTypes = Control.array<TypeEntity>();
        }        

        [MethodImpl(Inline)]
        public StructEntity(string Namespace, string Declarer, string Name, StructFacets Facets, string Description, MemberEntity[] Members, TypeEntity[] NestedTypes)
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