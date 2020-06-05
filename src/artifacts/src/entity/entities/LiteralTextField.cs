//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct LiteralTextField : IArtifactModel<LiteralTextField, FieldFacets>
    {
        [MethodImpl(Inline)]
        public LiteralTextField(string Declarer, string Identifier, FieldFacets Facets, string Description, string FieldValue)
        {
            this.Declarer = Declarer;
            this.Identifier =  Identifier;
            this.Facets = Facets;
            this.Description = Description;
            this.FieldValue = FieldValue;
            this.FieldType = "string";
        }
        
        public string Declarer {get;}
        
        public string Identifier {get;}

        public FieldFacets Facets {get;}

        public string Description {get;}

        public string FieldType {get;}

        public string FieldValue {get;}
    }
}