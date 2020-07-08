//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Tokens;

    using static Konst;

    public readonly struct InstructionTokenDataset
    {
        public readonly TokenInfo[] Models;

        public readonly string[] Meanings;

        public readonly string[] Identity;

        public readonly string[] Definitions;

        public readonly byte[] ValueEncoding;
    
        [MethodImpl(Inline), Op]
        public static int EncodeDefinitions(string[] src, byte[] dst)
            => asci.encode(src, dst, EncodingDelimiter);   
        
        [MethodImpl(Inline)]
        public static InstructionTokenDataset Create()
            => new InstructionTokenDataset(0);

        [MethodImpl(Inline), Op]
        public string Definition(InstructionTokenKind id)
            => Definitions[(int)id];

        [MethodImpl(Inline), Op]
        public string Meaning(InstructionTokenKind id)
            => Meanings[(int)id];

        [MethodImpl(Inline), Op]
        public ref readonly TokenInfo Token(InstructionTokenKind id)
            => ref Models[(int)id];

        [MethodImpl(Inline), Op]
        public string Identifier(InstructionTokenKind id)
            => Identity[(int)id];

        public const byte EncodingDelimiter = 0xFF;

        public int TokenCount
        {
            [MethodImpl(Inline)]
            get => Models.Length;
        }

        [MethodImpl(Inline)]
        InstructionTokenDataset(int i)
        {
            Models = InstructionTokenInfo.Models;
            Meanings = InstructionTokenInfo.Meanings;
            Identity = InstructionTokenInfo.Identity;
            Definitions = InstructionTokenInfo.Definitions;
            ValueEncoding = new byte[Definitions.Map(x => x.Length).Sum() + Definitions.Length];        
            EncodeDefinitions(Definitions,ValueEncoding);
        }
    }
}