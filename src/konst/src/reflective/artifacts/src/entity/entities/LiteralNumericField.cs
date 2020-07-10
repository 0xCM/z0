//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LiteralNumericField<T> : IArtifactModel<LiteralNumericField<T>, FieldFacets>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public LiteralNumericField(string Declarer, string Identifier, FieldFacets Facets, string Description, T FieldValue)
        {
            this.Declarer = Declarer;
            this.Identifier =  Identifier;
            this.Facets = Facets;
            this.Description = Description;
            this.FieldValue = FieldValue;
            this.FieldType = typeof(T).NumericKeywordNot();
        }
        
        public string Declarer {get;}
        
        public string Identifier {get;}

        public FieldFacets Facets {get;}

        public string Description {get;}

        public string FieldType {get;}

        public T FieldValue {get;}
    }
}