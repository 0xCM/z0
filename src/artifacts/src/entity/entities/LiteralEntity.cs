//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct LiteralEntity : IMemberArtifact<LiteralEntity, LiteralFacets>
    {
        public string Declarer {get;}
        
        public string Identifier {get;}

        public int Index {get;}

        public LiteralFacets Facets {get;}

        public string Description {get;}

        public ulong LiteralValue {get;}

        [MethodImpl(Inline)]
        internal LiteralEntity(string Declarer, string Identifier, int Index,  string Description, ulong LiteralValue)
        {
            this.Declarer = Declarer;
            this.Identifier =  Identifier;
            this.Index = Index;
            this.Facets = default;
            this.Description = Description;
            this.LiteralValue = LiteralValue;
        }
    }
}