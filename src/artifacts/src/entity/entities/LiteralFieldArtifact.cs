//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LiteralFieldArtifact : IArtifactModel<LiteralFieldArtifact, FieldFacets>
    {
        public string Declarer {get;}
        
        public string Identifier {get;}

        public FieldFacets Facets {get;}

        public string Description {get;}

        public string FieldType {get;}

        public object Value {get;}

        internal LiteralFieldArtifact(string Declarer, string Name, FieldFacets Facets, string Description, string FieldType, object Value)
        {
            this.Declarer = Declarer;
            this.Identifier =  Name;
            this.Facets = Facets;
            this.Description = Description;
            this.Value = Value;
            this.FieldType = FieldType;
        }
    }
}