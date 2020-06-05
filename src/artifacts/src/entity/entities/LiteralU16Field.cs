//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct LiteralU16Field : IArtifactModel<LiteralU16Field, FieldFacets>
    {
        [MethodImpl(Inline)]
        public static implicit operator LiteralNumericField<ushort>(LiteralU16Field src)
            => new LiteralNumericField<ushort>(src.Declarer,src.Identifier,src.Facets,src.Description,src.Value);
        
        [MethodImpl(Inline)]
        public LiteralU16Field(string Declarer, string Identifier, FieldFacets Facets, string Description, ushort Value)
        {
            this.Declarer = Declarer;
            this.Identifier =  Identifier;
            this.Facets = Facets;
            this.Description = Description;
            this.Value = Value;
            this.FieldType = "ushort";
        }
        
        public string Declarer {get;}
        
        public string Identifier {get;}

        public FieldFacets Facets {get;}

        public string Description {get;}

        public string FieldType {get;}

        public ushort Value {get;}
    }
}