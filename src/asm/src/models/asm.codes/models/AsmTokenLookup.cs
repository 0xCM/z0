//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    using Index = SemanticLookup<AsmTokenKind,string>;

    public readonly struct AsmTokenLookup
    {
        public readonly TableSpan<TokenRecord> Models;

        public readonly string[] Meanings;

        public readonly Index Identity;

        public readonly string[] Definitions;

        public readonly byte[] ValueEncoding;

        [MethodImpl(Inline), Op]
        static uint EncodeDefinitions(string[] src, byte[] dst)
            => asci.encode(src, dst, EncodingDelimiter);

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

        public const byte EncodingDelimiter = 0xFF;

        public int TokenCount
        {
            [MethodImpl(Inline)]
            get => Models.Length;
        }

        public AsmTokenLookup(AsmTokenIndex index)
        {
            Models = index.Model;
            Meanings = index.Meaning;
            Identity = index.Identifier;
            Definitions = index.Value;
            ValueEncoding = new byte[Definitions.Map(x => x.Length).Sum() + Definitions.Length];
            EncodeDefinitions(Definitions,ValueEncoding);
        }
    }
}