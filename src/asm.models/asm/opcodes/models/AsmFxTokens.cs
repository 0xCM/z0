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

    public readonly struct AsmFxTokens
    {
        public readonly TableSpan<TokenModel> Models;

        public readonly string[] Meanings;

        public readonly string[] Identity;

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
        public ref readonly TokenModel Token(AsmTokenKind id)
            => ref Models[(int)id];

        [MethodImpl(Inline), Op]
        public string Identifier(AsmTokenKind id)
            => Identity[(int)id];

        public const byte EncodingDelimiter = 0xFF;

        public int TokenCount
        {
            [MethodImpl(Inline)]
            get => Models.Length;
        }

        public AsmFxTokens(AsmTokenIndex index)
        {
            Models = index.Models;
            Meanings = index.Meanings;
            Identity = index.Identity;
            Definitions = index.Values;
            ValueEncoding = new byte[Definitions.Map(x => x.Length).Sum() + Definitions.Length];        
            EncodeDefinitions(Definitions,ValueEncoding);
        }
    }
}