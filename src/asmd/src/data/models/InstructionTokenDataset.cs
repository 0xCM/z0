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
        [MethodImpl(Inline)]
        public static InstructionTokenDataset Create()
            => new InstructionTokenDataset(0);

        public const byte EncodingDelimiter = 0xFF;

        public readonly TokenInfo[] Constructed;

        public readonly string[] Purpose;

        public readonly string[] Identity;

        public readonly string[] Values;

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
            Purpose = InstructionTokenData.Purposes;
            Identity = InstructionTokenData.Identity;
            Values = InstructionTokenData.Values;
            ValueEncoding = new byte[Values.Map(x => x.Length).Sum() + Values.Length];        
            EncodeTokenValues(Values,ValueEncoding);
        }

        [MethodImpl(Inline), Op]
        public string value(InstructionToken id)
            => Values[(int)id];

        [MethodImpl(Inline), Op]
        public string purpose(InstructionToken id)
            => Purpose[(int)id];

        [MethodImpl(Inline), Op]
        public ref readonly TokenInfo Token(InstructionToken id)
            => ref Constructed[(int)id];


        [MethodImpl(Inline), Op]
        public string identifier(InstructionToken id)
            => Identity[(int)id];

        static int EncodeTokenValues(string[] ITokenValues, byte[] buffer)
        {
            ReadOnlySpan<string> src = ITokenValues;                        
            Span<byte> dst = buffer;
            var length  = asci.encode(src, dst, EncodingDelimiter);   
            return length;
        }
    }
}