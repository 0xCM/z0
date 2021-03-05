//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;

    using static Part;
    using static memory;

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
            ParsingNumber = false;
            ParsingString = false;
            Run();
        }

        bool ParsingNumber;

        bool ParsingString;

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
                c = skip(Subject,CurrentPos++);
                return true;
            }
            else
            {
                c = (char)0;
                return false;
            }
        }


    }

}