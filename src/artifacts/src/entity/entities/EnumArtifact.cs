//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct EnumArtifact : ITypeArtifact<EnumArtifact,EnumLiteralField,TypeFacets>
    {
        public string Namespace {get;}

        public string Declarer {get;}

        public string Identifier {get;}

        public EnumScalarKind DataType {get;}

        public TypeFacets Facets {get;}

        public string Description {get;}
        
        public EnumLiteralField[] Members {get;}

        [MethodImpl(Inline)]
        public EnumArtifact(string Namespace, string Declarer, string Identifier, EnumScalarKind DataType, TypeFacets Facets, string Description, EnumLiteralField[] Members)
        {
            this.Namespace = Namespace;
            this.Declarer = Declarer;
            this.Identifier = Identifier;
            this.DataType = DataType;
            this.Facets = Facets;
            this.Description = Description;
            this.Members = Members;
        }        
    }
}