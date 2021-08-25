//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static Root;

    using SQ = SymbolicQuery;

    using llvm;

    public struct AsmIdParseResult
    {
        public CharBlock16 Mnemonic;

        public bit Success;

        public bit Rejected;
    }

    struct AsmIdParser
    {
        AsmIdParseResult Output;

        ParserState State;

        AsmId Input;

        byte MnemonicLength;

        ulong Digits;

        byte DigitCount;

        const ParserState ParsingMnemonic = ParserState.ParsingMnemonic;

        const ParserState ParsingDigits = ParserState.ParsingDigits;

        const ParserState ParsingOperands = ParserState.ParsingOperands;

        const ParserState Rejected = ParserState.Rejected;

        const ParserState Success = ParserState.Success;

        const ParserState Failure = ParserState.Failure;

        enum ParserState : byte
        {
            None,

            ParsingMnemonic,

            ParsingDigits,

            ParsingOperands,

            Rejected,

            Success,

            Failure
        }

        void Reset()
        {
            Output = default;
            State = 0;
            Input = default;
            MnemonicLength = 0;
            Digits = 0;
            DigitCount = 0;
        }

        public void Parse(Sym<AsmId> src)
        {
            Reset();
            Input = src.Kind;
            var name = span(src.Name.Content);
            Parse(name);
        }

        void Parse(ReadOnlySpan<char> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                State = Parse(c);
                switch(State)
                {
                    case Rejected:
                    break;
                    case Success:
                    break;
                    case Failure:
                    break;
                }
            }
        }

        ParserState Parse(char c)
        {
            if(c == Chars.Underscore)
                return Rejected;

            var state = State;
            switch(State)
            {
                case ParsingMnemonic:
                    if(SQ.uppercase(c))
                    {
                        Output.Mnemonic[MnemonicLength++] = c;
                    }
                    else if(SQ.lowercase(c))
                    {
                        state = ParsingOperands;

                    }
                    else if(SQ.digit(base10,c))
                    {
                        Digits |= Digital.digit(c);
                        DigitCount++;
                        state = ParsingDigits;
                    }
                break;

                case ParsingDigits:
                    if(SQ.digit(base10,c))
                    {
                        Digits |= ((Digital.digit(c)*DigitCount) << 8*DigitCount);
                    }
                    else if(SQ.lowercase(c))
                    {
                        state = ParsingOperands;
                    }
                    else if(SQ.uppercase(c))
                    {

                    }

                break;

                case ParsingOperands:
                break;
            }

            return default;
        }
    }
}