//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    using C = AsciChar;

    using static Chars;
    using SQ = SymbolicQuery;

    public class AsmExprParser
    {
        enum ParserStep : byte
        {
            None = 0,

            ParsingMnemonic,

            ParsedMnemonic,

            ParsingOperand,

            ParsedOperand
        }

        uint Pos;

        Index<C> Mnemonic;

        void Reset()
        {
            Pos = 0;
            Mnemonic = alloc<C>(32);
        }

        public void Parse(ReadOnlySpan<char> src)
        {
            Reset();
            var count = src.Length;
            var result = bit.On;
            var step = ParserStep.None;
            for(var i=0u; i<count; i++)
            {
                Pos = i;
                ref readonly var c = ref skip(src,Pos);
                switch(step)
                {
                    case ParserStep.None:
                        if(SQ.whitespace(c))
                            continue;
                        else
                        {
                            step = ParserStep.ParsingMnemonic;
                            step = Consume(step, c);
                        }
                    continue;
                    default:
                        step = Consume(step, c);
                    break;
                }

            }
        }

        ParserStep Consume(ParserStep step, char src)
        {
            var result = step;
            switch(step)
            {
                case ParserStep.ParsingMnemonic:
                    switch(Pos)
                    {
                        case 0:
                            switch(src)
                            {
                                case a:
                                case A:
                                break;
                                case b:
                                case B:
                                break;
                                case c:
                                case Chars.C:
                                break;
                                case d:
                                case D:
                                break;
                                case e:
                                case E:
                                break;
                                case f:
                                case F:
                                break;
                            }
                        break;
                    }
                break;
                case ParserStep.ParsedMnemonic:
                break;
                case ParserStep.ParsingOperand:
                break;
                default:
                    break;
            }


            return result;

        }
    }
}