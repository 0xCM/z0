//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    using static Seed;

    public readonly struct EnumEntity : ITypeArtifact<EnumEntity,LiteralEntity,EnumFacets>
    {
        public string Namespace {get;}

        public string Declarer {get;}

        public string Identifier {get;}

        public EnumFacets Facets {get;}

        public string Description {get;}
        
        public LiteralEntity[] Members {get;}

        [MethodImpl(Inline)]
        public EnumEntity(string Namespace, string Declarer, string Identifier, EnumFacets Facets, string Description, LiteralEntity[] Members)
        {
            this.Namespace = Namespace;
            this.Declarer = Declarer;
            this.Identifier = Identifier;
            this.Facets = Facets;
            this.Description = Description;
            this.Members = Members;
        }        
    }
}