//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct LiteralU64Field : IArtifactModel<LiteralU64Field, FieldFacets>
    {
        [MethodImpl(Inline)]
        public static implicit operator LiteralNumericField<ulong>(LiteralU64Field src)
            => new LiteralNumericField<ulong>(src.Declarer,src.Identifier,src.Facets,src.Description,src.Value);
        
        [MethodImpl(Inline)]
        public LiteralU64Field(string Declarer, string Identifier, FieldFacets Facets, string Description, ulong Value)
        {
            this.Declarer = Declarer;
            this.Identifier =  Identifier;
            this.Facets = Facets;
            this.Description = Description;
            this.Value = Value;
            this.FieldType = "ulong";
        }
        
        public string Declarer {get;}
        
        public string Identifier {get;}

        public FieldFacets Facets {get;}

        public string Description {get;}

        public string FieldType {get;}

        public ulong Value {get;}
    }
}