//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ParsedEncoding : ILocatedCode<ParsedEncoding,X86Code>
    {
        readonly BinaryCode Input;

        public X86Code ParseResult {get;}

        public X86Code Encoded
        {
            [MethodImpl(Inline)]
            get => ParseResult;
        }

        public X86Code ParseInput
        {
            [MethodImpl(Inline)]
            get => new X86Code(Address, Input);
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Encoded.Address;
        }

        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Encoded.Length;
        }

        public ref readonly byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Encoded[index];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public ParsedEncoding(MemoryAddress src, X86Code raw, X86Code parsed)
        {
            z.insist(src, raw.Address);
            z.insist(src, parsed.Address);
            Input = raw;
            ParseResult = parsed;
        }

        [MethodImpl(Inline)]
        public ParsedEncoding(X86Code src, X86Code parsed)
        {
            z.insist(src.Address, parsed.Address);
            Input = src;
            ParseResult = parsed;
        }

        [MethodImpl(Inline)]
        public ParsedEncoding(MemoryAddress src, byte[] raw, byte[] parsed)
        {
            Input = new X86Code(src, raw);
            ParseResult = new X86Code(src, parsed);
        }

        [MethodImpl(Inline)]
        public bool Equals(ParsedEncoding src)
            => Encoded.Equals(src.Encoded);

        public string Format()
            => Encoded.Format();

        public override string ToString()
            => Format();
    }
}