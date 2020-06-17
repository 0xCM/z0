//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LiteralU8Field : IArtifactModel<LiteralU8Field, FieldFacets>
    {
        [MethodImpl(Inline)]
        public static implicit operator LiteralNumericField<byte>(LiteralU8Field src)
            => new LiteralNumericField<byte>(src.Declarer,src.Identifier,src.Facets,src.Description,src.Value);
        
        [MethodImpl(Inline)]
        public LiteralU8Field(string Declarer, string Identifier, FieldFacets Facets, string Description, byte Value)
        {
            this.Declarer = Declarer;
            this.Identifier =  Identifier;
            this.Facets = Facets;
            this.Description = Description;
            this.Value = Value;
            this.FieldType = "byte";
        }
        
        public string Declarer {get;}
        
        public string Identifier {get;}

        public FieldFacets Facets {get;}

        public string Description {get;}

        public string FieldType {get;}

        public byte Value {get;}
    }
}