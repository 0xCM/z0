//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; 

    public readonly struct TypeEntity : IArtifactModel<TypeEntity,TypeFacets>
    {
        public string Namespace {get;}

        public string Declarer {get;}

        public string Identifier {get;}

        public TypeFacets Facets {get;}

        public string Description {get;}

        public MemberEntity[] Members {get;}

        public TypeEntity[] NestedTypes {get;}

        [MethodImpl(Inline)]
        public TypeEntity(string Namespace, string Declarer, string Identifier, TypeFacets Facets, string Description,  MemberEntity[] Members, TypeEntity[] NestedTypes)
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