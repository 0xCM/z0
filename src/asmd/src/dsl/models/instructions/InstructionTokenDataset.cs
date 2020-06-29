//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct InstructionTokenDataset
    {
        [MethodImpl(Inline), Op]
        public static int EncodeDefinitions(string[] src, byte[] dst)
            => asci.encode(src, dst, EncodingDelimiter);   
        
        [MethodImpl(Inline)]
        public static InstructionTokenDataset Create()
            => new InstructionTokenDataset(0);

        [MethodImpl(Inline), Op]
        public string Definition(InstructionToken id)
            => Definitions[(int)id];

        [MethodImpl(Inline), Op]
        public string Meaning(InstructionToken id)
            => Meanings[(int)id];

        [MethodImpl(Inline), Op]
        public ref readonly TokenInfo Token(InstructionToken id)
            => ref Constructed[(int)id];

        [MethodImpl(Inline), Op]
        public string Identifier(InstructionToken id)
            => Identity[(int)id];

        public const byte EncodingDelimiter = 0xFF;

        public readonly TokenInfo[] Constructed;

        public readonly string[] Meanings;

        public readonly string[] Identity;

        public readonly string[] Definitions;

        public readonly byte[] ValueEncoding;

        public int TokenCount
        {
            [MethodImpl(Inline)]
            get => Constructed.Length;
        }

        [MethodImpl(Inline)]
        InstructionTokenDataset(int i)
        {
            Constructed = InstructionTokenData.Tokens;
            Meanings = InstructionTokenInfo.Meanings;
            Identity = InstructionTokenInfo.Identity;
            Definitions = InstructionTokenInfo.Definitions;
            ValueEncoding = new byte[Definitions.Map(x => x.Length).Sum() + Definitions.Length];        
            EncodeDefinitions(Definitions,ValueEncoding);
        }



    }
}