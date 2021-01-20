//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    using Index = SemanticLookup<AsmTokenKind,string>;

    public readonly struct AsmTokenLookup
    {
        public Index<TokenRecord> Models {get;}

        public string[] Meanings {get;}

        public Index Identity {get;}

        public string[] Definitions {get;}

        public byte[] ValueEncoding {get;}

        public AsmTokenLookup(AsmTokenIndex index)
        {
            Models = index.Records;
            Meanings = index.Meaning;
            Identity = index.Identifier;
            Definitions = index.Value;
            ValueEncoding = new byte[Definitions.Map(x => x.Length).Sum() + Definitions.Length];
            EncodeDefinitions(Definitions,ValueEncoding);
        }

        [MethodImpl(Inline), Op]
        public string Definition(AsmTokenKind id)
            => Definitions[(int)id];

        [MethodImpl(Inline), Op]
        public string Meaning(AsmTokenKind id)
            => Meanings[(int)id];

        [MethodImpl(Inline), Op]
        public ref readonly TokenRecord Token(AsmTokenKind id)
            => ref Models[(int)id];

        [MethodImpl(Inline), Op]
        public ref readonly string Identifier(AsmTokenKind id)
            => ref Identity[id];

        public int TokenCount
        {
            [MethodImpl(Inline)]
            get => Models.Length;
        }

        public const byte EncodingDelimiter = 0xFF;

        [MethodImpl(Inline), Op]
        static uint EncodeDefinitions(string[] src, byte[] dst)
            => Asci.encode(src, dst, EncodingDelimiter);

    }
}