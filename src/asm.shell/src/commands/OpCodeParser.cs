//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static AsciCode;
    using static AsmOpCodeTokens;

    using AC = AsciCode;
    using SQ = SymbolicQuery;

    public readonly partial struct Machines
    {
        public sealed class OpCodeParser : CharParser
        {
            const string LegacyPrefixTokens =
                "66\0" +
                "F2\0" +
                "F3\0" +
                "0F\0" +
                "0F38\0";

            const string ModRMTokens =
                "/r\0" +
                "/0\0" +
                "/1\0" +
                "/2\0" +
                "/3\0" +
                "/4\0" +
                "/5\0" +
                "/6\0" +
                "/7\0";

            const string RexPrefixTokens =
                "REX\0" +
                "REX.W\0" +
                "REX.R\0" +
                "REX.X\0" +
                "REX.B\0";

            const string RexBTokens =
                "+rb\0" +
                "+rw\0" +
                "+rd\0" +
                "+ro\0" +
                "N.A.\0" +
                "N.E\0";

            static bit match(ReadOnlySpan<char> src, out RexBToken dst)
            {
                var matched = bit.Off;
                var length = src.Length;
                dst = default;
                if(length < 3)
                    return matched;

                ref readonly var c0 = ref skip(src,0);
                ref readonly var c1 = ref skip(src,1);
                ref readonly var c2 = ref skip(src,2);

                switch(length)
                {
                    case 3:
                        switch(c0)
                        {
                            case '+':
                                switch(c1)
                                {
                                    case 'r':
                                        switch(c2)
                                        {
                                            case 'b':
                                                dst = RexBToken.rb;
                                                matched = true;
                                            break;
                                            case 'w':
                                                dst = RexBToken.rw;
                                                matched = true;
                                            break;
                                            case 'd':
                                                dst = RexBToken.rd;
                                                matched = true;
                                            break;
                                            case 'o':
                                                dst = RexBToken.ro;
                                                matched = true;
                                            break;
                                        }
                                    break;
                                }
                            break;
                        }

                    break;
                    case 4:
                        ref readonly var c3 = ref skip(src,3);
                        switch(c0)
                        {
                            case 'N':
                            switch(c1)
                            {
                                case '.':
                                switch(c2)
                                {
                                    case 'A':
                                        dst = RexBToken.NA;
                                        matched = true;
                                    break;
                                    case 'E':
                                        dst = RexBToken.NE;
                                        matched = true;
                                    break;
                                }
                                break;
                            }
                            break;
                        }

                    break;
                }

                return matched;
            }

            const string VexTokens =
                "VEX\0" +
                "LZ\0" +
                "LIG\0" +
                "WIG\0" +
                "W0\0" +
                "W1\0" +
                "W128\0" +
                "W256\0";

            const string EVexTokens =
                "EVEX\0" +
                "VEX\0" +
                "LZ\0" +
                "LIG\0" +
                "WIG\0" +
                "W0\0" +
                "W1\0" +
                "W128\0" +
                "W256\0" +
                "W512\0";

            const string DispTokens =
                "cb\0" +
                "cw\0" +
                "cd\0" +
                "cp\0" +
                "c0\0" +
                "ct\0";

            static bit match(ReadOnlySpan<char> src,  out DispToken dst)
            {
                dst = default;
                var matched = bit.Off;
                if(src.Length < 2)
                    return matched;

                ref readonly var c0 = ref skip(src,0);
                ref readonly var c1 = ref skip(src,1);
                switch(c0)
                {
                    case 'c':
                    switch(c1)
                    {
                        case 'b':
                            dst = DispToken.cb;
                            matched = true;
                        break;

                        case 'w':
                            dst = DispToken.cw;
                            matched = true;
                        break;

                        case 'd':
                            dst = DispToken.cd;
                            matched = true;
                        break;

                        case 'p':
                            dst = DispToken.cp;
                            matched = true;
                        break;

                        case 'o':
                            dst = DispToken.co;
                            matched = true;
                        break;

                        case 't':
                            dst = DispToken.cb;
                            matched = true;
                        break;
                    }
                    break;
                }

                return matched;
            }

            const string SegOverrideTokens =
                "CS\0" +
                "SS\0" +
                "DS\0" +
                "ES\0" +
                "FS\0" +
                "GS\0";

            const string ImmSizeTokens =
                "ib\0" +
                "iw\0" +
                "id\0" +
                "io\0";

            static string[] FpuDigitTokens = new string[]
            {
                "+0\0" +
                "+1\0" +
                "+2\0" +
                "+3\0" +
                "+4\0" +
                "+5\0" +
                "+6\0" +
                "+7\0"
            };

            const string MaskTokens =
                "{k1}\0" +
                "{k1}{z}\0";

            const string ExclusionTokens =
                "NP\0" +
                "NFx\0";

            enum AtomKind : byte
            {
                None = 0,

                Digit,

                // '+', '.'
                Operator,

                Whitespace,

                HexChar,

                Other,
            }

            enum ParserAction : byte
            {
                None = 0,

                ParsedDigit,

                ParsedLetter,

                ParsedOperator,

                ParsedWhitespace,
            }

            struct ParserState
            {
                public uint Step;

                public uint Position;

                public ParserAction LastAction;

                public Index<char> Received;

                public bit Finished;

                uint _Marker;

                [MethodImpl(Inline)]
                public void Mark()
                {
                    _Marker = Position;
                }

                [MethodImpl(Inline)]
                public uint Marker()
                    => _Marker;

                [MethodImpl(Inline)]
                public void Store(char c)
                    => Received[Position++] = c;

                [MethodImpl(Inline)]
                public ReadOnlySpan<char> Marked()
                {
                    var length = Position - _Marker;
                    if(length > 0)
                        return slice(Received.View, _Marker, length);
                    else
                        return default;
                }

                public uint Capacity
                {
                    [MethodImpl(Inline)]
                    get => Received.Count;
                }

                [MethodImpl(Inline)]
                public ref readonly char Current()
                    => ref Received[Position - 1];

                [MethodImpl(Inline)]
                public ref readonly char Prior()
                    => ref Received[Position - 2];

                public void Clear()
                {
                    Step = 0;
                    Position = 0;
                    LastAction = 0;
                    Finished = 0;
                    _Marker = 0;
                    Received.Clear();
                }
            }

            ParserState State;

            public OpCodeParser()
            {
                State = default;
                State.Received = alloc<char>(256);
            }

            protected override void Reset()
                => State.Clear();

            public override bit Finished()
                => State.Finished;

            TokenKind Classify(ReadOnlySpan<char> src)
            {
                var length = src.Length;
                var kind = TokenKind.None;
                switch(length)
                {
                    case 1:
                        kind = Classify(n1, src);
                        break;
                    case 2:
                        kind = Classify(n2, src);
                        break;
                    case 3:
                        kind = Classify(n3, src);
                        break;
                    case 4:
                        kind = Classify(n4, src);
                        break;
                    case 5:
                        kind = Classify(n5, src);
                        break;
                    case 6:
                        kind = Classify(n6, src);
                        break;
                    case 7:
                        kind = Classify(n7, src);
                        break;
                }

                return 0;
            }

            /// <summary>
            /// Classifies tokens of length 1
            /// </summary>
            /// <param name="n"></param>
            /// <param name="src"></param>
            TokenKind Classify(N1 n, ReadOnlySpan<char> src)
            {
                return 0;
            }

            /// <summary>
            /// Classifies tokens of length 2
            /// </summary>
            /// <param name="n"></param>
            /// <param name="src"></param>
            TokenKind Classify(N2 n, ReadOnlySpan<char> src)
            {
                ref readonly var c0 = ref skip(src,0);
                ref readonly var c1 = ref skip(src,1);

                if(SQ.hexdigit(skip(src,0)) && SQ.hexdigit(skip(src,1)))
                    return TokenKind.Byte;
                switch(c0)
                {
                    case 'a':
                    break;
                }
                return 0;
            }

            /// <summary>
            /// Classifies tokens of length 3
            /// </summary>
            /// <param name="n"></param>
            /// <param name="src"></param>
            TokenKind Classify(N3 n, ReadOnlySpan<char> src)
            {
                return 0;
            }

            /// <summary>
            /// Classifies tokens of length 4
            /// </summary>
            /// <param name="n"></param>
            /// <param name="src"></param>
            TokenKind Classify(N4 n, ReadOnlySpan<char> src)
            {
                return 0;
            }

            /// <summary>
            /// Classifies tokens of length 5
            /// </summary>
            /// <param name="n"></param>
            /// <param name="src"></param>
            TokenKind Classify(N5 n, ReadOnlySpan<char> src)
            {
                return 0;
            }

            /// <summary>
            /// Classifies tokens of length 6
            /// </summary>
            /// <param name="n"></param>
            /// <param name="src"></param>
            TokenKind Classify(N6 n, ReadOnlySpan<char> src)
            {
                return 0;
            }

            /// <summary>
            /// Classifies tokens of length 7
            /// </summary>
            /// <param name="n"></param>
            /// <param name="src"></param>
            TokenKind Classify(N7 n, ReadOnlySpan<char> src)
            {
                return 0;
            }

            void Collect()
            {
                var collected = State.Marked();
                if(collected.Length > 0)
                {
                    Classify(collected);
                }
            }

            void Step()
            {
                switch(Classify(State.Current()))
                {
                    case AtomKind.Whitespace:
                        Collect();
                        State.Mark();
                        break;
                }
            }

            public override bit Accept(char src)
            {
                var accepted = bit.On;
                if(!State.Finished && State.Position < State.Capacity - 1)
                {
                    State.Store(src);
                    Step();
                }
                else
                {
                    return false;
                }

                return accepted;
            }

            static AtomKind Classify(char src)
            {
                var kind = AtomKind.Other;
                switch((AsciCode)src)
                {
                    case AC.Space:
                    case LF:
                    case CR:
                    case FF:
                    case Tab:
                    case VTab:
                        kind = AtomKind.Whitespace;
                        break;
                    case d0:
                    case d1:
                    case d2:
                    case d3:
                    case d4:
                    case d5:
                    case d6:
                    case d7:
                    case d8:
                    case d9:
                        kind = AtomKind.Digit;
                        break;
                    case FS:
                    case Plus:
                    case Dot:
                        kind = AtomKind.Operator;
                        break;
                    case a:
                    case b:
                    case c:
                    case d:
                    case e:
                    case f:
                    case A:
                    case B:
                    case C:
                    case D:
                    case E:
                    case F:
                        kind = AtomKind.HexChar;
                        break;
                }
                return kind;
            }
        }
    }
}