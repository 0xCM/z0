//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using S = AsmHexParser.ParserState;

    public ref struct AsmHexParser
    {
        public enum ParserState : byte
        {
            None,

            ParsingDigits,
        }

        ReadOnlySpan<AsciChar> Source;

        Span<byte> Target;

        Span<ParserState> States;

        int CurrentPos;

        int LastPos;

        ByteSize ParsedSize;

        [MethodImpl(Inline)]
        ref S Current()
            => ref seek(States, 0);

        [MethodImpl(Inline)]
        void Current(S state)
            => Current() = state;

        [MethodImpl(Inline)]
        ref S Next()
            => ref seek(States, 1);

        [MethodImpl(Inline)]
        void Next(S state)
            => Next() = state;

        [MethodImpl(Inline)]
        void Init(string src, Span<byte> dst)
        {
            Source = recover<char,AsciChar>(span(src));
            Target = dst;
            CurrentPos = 0;
            LastPos = root.min(src.Length, dst.Length) - 1;
            States = new S[2]{0,0};
        }

        [MethodImpl(Inline)]
        void ParsingDigits()
            => Current() = S.ParsingDigits;

        void Parse(AsciChar c)
        {
            if(Hex.parse(c, out var d))
                ParsingDigits();
        }

        void Parse()
        {
            while(CurrentPos <= LastPos)
            {
                ref readonly var c = ref skip(Source, CurrentPos++);
                Parse(c);
            }
        }

        public ByteSize Parse(string src, Span<byte> dst)
        {
            Init(src, dst);
            Parse();
            return ParsedSize;
        }
    }
}