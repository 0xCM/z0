//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct EnumLiteralField : IMemberArtifact<EnumLiteralField, LiteralFacets>
    {
        public string Declarer {get;}
        
        public string Identifier {get;}

        public int Index {get;}

        public LiteralFacets Facets {get;}

        public string Description {get;}

        public EnumScalarKind DataType {get;}

        public ulong Value {get;}

        [MethodImpl(Inline)]
        internal EnumLiteralField(string Declarer, string Identifier, int Index, string Description, EnumScalarKind DataType, ulong Value)
        {
            this.Declarer = Declarer;
            this.Identifier =  Identifier;
            this.Index = Index;
            this.Facets = default;
            this.Description = Description;
            this.DataType = DataType;
            this.Value = Value;
        }
    }
}