//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;
    using static Chars;

    enum OpCodePart : uint
    {
        None = 0,

        HexDigit,

        RegDigit,

        Prefix,
    }

    public ref struct OpCodeParser
    {
        public Span<AsmByte> Bytes;

        public Span<string> Modifiers;

        ReadOnlySpan<char> Subject;

        uint CurrentPos;

        uint LastPos;

        public void Parse(string src)
        {
            Subject = src;
            CurrentPos = 0;
            LastPos = (uint)src.Length - 1;
            Run();
        }

        void Run()
        {
            while(Next(out var c))
            {

            }
        }

        bool Next(out char c)
        {
            if(CurrentPos < LastPos)
            {
                var prior = CurrentPos != 0 ? skip(Subject,CurrentPos) : Null;
                c = skip(Subject, CurrentPos++);
                if(prior == Null)
                    Classify(c,Null);
                else
                    Classify(prior,c);
                return true;
            }
            else
            {
                c = (char)0;
                return false;
            }
        }

        void Classify(char c0, char c1)
        {
            if(c1 == Null)
            {

            }
        }
    }
}