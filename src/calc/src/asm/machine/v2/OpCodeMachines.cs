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
    using static Machines;

    using AC = AsciCode;
    using SQ = SymbolicQuery;

    [ApiHost]
    public readonly struct OpCodeMachines
    {
        enum ParserAction : byte
        {
            None = 0,

            ParsedDigit,

            ParsedLetter,

            ParsedOperator,

            ParsedWhitespace,
        }

        enum AtomKind : byte
        {
            None = 0,

            Digit,

            // '+', '.'
            Dot,

            Plus,

            Whitespace,

            HexChar,

            Other,
        }

        [Op]
        static AsmOcTokenKind classify(ReadOnlySpan<char> src)
        {
            var length = src.Length;
            var kind = AsmOcTokenKind.None;
            switch(length)
            {
                case 1:
                    kind = classify(n1, src);
                    break;
                case 2:
                    kind = classify(n2, src);
                    break;
                case 3:
                    kind = classify(n3, src);
                    break;
                case 4:
                    kind = classify(n4, src);
                    break;
                case 5:
                    kind = classify(n5, src);
                    break;
                case 6:
                    kind = classify(n6, src);
                    break;
                case 7:
                    kind = classify(n7, src);
                    break;
            }

            return 0;
        }

        /// <summary>
        /// Classifies tokens of length 1
        /// </summary>
        /// <param name="n"></param>
        /// <param name="src"></param>
        [Op]
        static AsmOcTokenKind classify(N1 n, ReadOnlySpan<char> src)
        {
            return 0;
        }

        /// <summary>
        /// Classifies tokens of length 2
        /// </summary>
        /// <param name="n"></param>
        /// <param name="src"></param>
        [Op]
        static AsmOcTokenKind classify(N2 n, ReadOnlySpan<char> src)
        {
            ref readonly var c0 = ref skip(src,0);
            ref readonly var c1 = ref skip(src,1);
            if(SQ.hexdigit(skip(src,0)) && SQ.hexdigit(skip(src,1)))
                return AsmOcTokenKind.Byte;
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
        [Op]
        static AsmOcTokenKind classify(N3 n, ReadOnlySpan<char> src)
        {
            return 0;
        }

        /// <summary>
        /// Classifies tokens of length 4
        /// </summary>
        /// <param name="n"></param>
        /// <param name="src"></param>
        [Op]
        static AsmOcTokenKind classify(N4 n, ReadOnlySpan<char> src)
        {
            return 0;
        }

        /// <summary>
        /// Classifies tokens of length 5
        /// </summary>
        /// <param name="n"></param>
        /// <param name="src"></param>
        [Op]
        static AsmOcTokenKind classify(N5 n, ReadOnlySpan<char> src)
        {
            return 0;
        }

        /// <summary>
        /// Classifies tokens of length 6
        /// </summary>
        /// <param name="n"></param>
        /// <param name="src"></param>
        [Op]
        static AsmOcTokenKind classify(N6 n, ReadOnlySpan<char> src)
        {
            return 0;
        }

        /// <summary>
        /// Classifies tokens of length 7
        /// </summary>
        /// <param name="n"></param>
        /// <param name="src"></param>
        [Op]
        static AsmOcTokenKind classify(N7 n, ReadOnlySpan<char> src)
        {
            return 0;
        }

        [Op]
        static AtomKind classify(char src)
        {
            var kind = AtomKind.Other;
            switch((AsciCode)src)
            {
                case AC.Space:
                case NL:
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
                    kind = AtomKind.Plus;
                    break;
                case Dot:
                    kind = AtomKind.Dot;
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

        struct CharParserState<T>
            where T : unmanaged
        {
            public uint Step;

            public uint Position;

            public T LastAction;

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
                LastAction = default;
                Finished = 0;
                _Marker = 0;
                Received.Clear();
            }
        }

        [ApiHost]
        public sealed class OpCodeParser : CharParser
        {
            CharParserState<ParserAction> State;

            public OpCodeParser()
            {
                State = default;
                State.Received = alloc<char>(256);
            }

            protected override void Reset()
                => State.Clear();

            [Op]
            void Collect()
            {
                var collected = State.Marked();
                if(collected.Length > 0)
                {
                    classify(collected);
                }
            }

            [Op]
            void Step()
            {
                switch(OpCodeMachines.classify(State.Current()))
                {
                    case AtomKind.Whitespace:
                        Collect();
                        State.Mark();
                        break;
                }
            }

            [Op]
            bit Input(char src)
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

            public override bit Accept(char src)
                => Input(src);
        }
    }
}