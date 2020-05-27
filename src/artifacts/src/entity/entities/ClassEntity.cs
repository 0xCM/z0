//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct ClassEntity : ITypeArtifact<ClassEntity,ClassFacets>
    {
        public string Namespace {get;}

        public string Declarer {get;}

        public string Identifier {get;}

        public string Description {get;}

        public ClassFacets Facets {get;}

        public MemberEntity[] Members {get;}

        public TypeEntity[] NestedTypes {get;}

        [MethodImpl(Inline)]
        public ClassEntity(string Namespace, string Identifier, ClassFacets Facets, string Description, params MemberEntity[] Members)
        {
            this.Namespace = Namespace;
            this.Declarer = string.Empty;
            this.Identifier = Identifier;
            this.Facets = Facets;
            this.Description = Description;
            this.Members = Members;
            this.NestedTypes = Control.array<TypeEntity>();            
        }        

        [MethodImpl(Inline)]
        public ClassEntity(string Namespace, string Declarer, string Name, ClassFacets Facets, string Description, TypeEntity[] NestedTypes, params MemberEntity[] Members)
        {            
            this.Namespace = Namespace;
            this.Declarer = Declarer;
            this.Identifier = Name;
            this.Facets = Facets;
            this.Description = Description;
            this.Members = Members;
            this.NestedTypes = NestedTypes;
        }        
    }
}