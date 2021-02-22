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

    [ApiHost]
    public ref struct AsmHexParser
    {
        public static AsmHexParser create()
            => new AsmHexParser(alloc<HexDigit>(32));
        public enum ParserState : byte
        {
            None,

            ParsedDigit,
        }

        ReadOnlySpan<AsciChar> Source;

        Span<byte> Target;

        Span<HexDigit> Digits;

        Span<ParserState> States;

        int CurrentPos;

        int LastPos;

        int DigitPos;

        ByteSize ParsedSize;

        AsmHexParser(Span<HexDigit> buffer)
        {
            Digits = buffer;
            Source = default;
            Target = default;
            CurrentPos = 0;
            LastPos = 0;
            ParsedSize = 0;
            DigitPos = 0;
            States = new ParserState[2]{0,0};
        }

        [MethodImpl(Inline), Op]
        ref ParserState Current()
            => ref seek(States, 0);

        [MethodImpl(Inline), Op]
        void Current(ParserState state)
            => Current() = state;

        [MethodImpl(Inline), Op]
        ref ParserState Next()
            => ref seek(States, 1);

        [MethodImpl(Inline), Op]
        void Next(ParserState state)
            => Next() = state;

        [MethodImpl(Inline)]
        void Reset(string src, Span<byte> dst)
        {
            Source = recover<char,AsciChar>(span(src));
            Target = dst;
            CurrentPos = 0;
            DigitPos = 0;
            LastPos = root.min(src.Length, dst.Length) - 1;
        }

        [MethodImpl(Inline), Op]
        void ParsedDigit()
            => Current() = ParserState.ParsedDigit;

        [MethodImpl(Inline), Op]
        void Parse(AsciChar c)
        {
            if(Hex.parse(c, out var d))
            {
                seek(Digits, DigitPos++) = d;
                ParsedDigit();
            }
        }

        [Op]
        void Parse()
        {
            while(CurrentPos <= LastPos)
                Parse(skip(Source, CurrentPos++));
        }

        [Op]
        public ByteSize Parse(string src, Span<byte> dst)
        {
            Reset(src, dst);
            Parse();
            return ParsedSize;
        }
    }
}