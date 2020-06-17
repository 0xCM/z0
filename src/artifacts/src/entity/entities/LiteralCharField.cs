//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LiteralCharField : IArtifactModel<LiteralCharField, FieldFacets>
    {
        [MethodImpl(Inline)]
        public static implicit operator LiteralNumericField<ushort>(LiteralCharField src)
            => new LiteralNumericField<ushort>(src.Declarer,src.Identifier,src.Facets,src.Description,src.Value);
        
        [MethodImpl(Inline)]
        public LiteralCharField(string Declarer, string Identifier, FieldFacets Facets, string Description, char Value)
        {
            this.Declarer = Declarer;
            this.Identifier =  Identifier;
            this.Facets = Facets;
            this.Description = Description;
            this.Value = Value;
            this.FieldType = "char";
        }
        
        public string Declarer {get;}
        
        public string Identifier {get;}

        public FieldFacets Facets {get;}

        public string Description {get;}

        public string FieldType {get;}

        public char Value {get;}
    }
}