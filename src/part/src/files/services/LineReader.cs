//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    public struct LineReader : IDisposable
    {
        readonly StreamReader Source;

        uint Consumed;

        [MethodImpl(Inline)]
        public LineReader(StreamReader src)
        {
            Source = src;
            Consumed = 0;
        }

        public void Dispose()
        {
            Source?.Dispose();
        }

        static bool IsNumbered(ReadOnlySpan<char> src)
        {
            if(src.Length < 9)
                return false;

            if(skip(src,8) != Chars.Colon)
                return false;

            for(var i=0; i<7; i++)
            {
                if(!char.IsDigit(skip(src,i)))
                    return false;
            }
            return true;
        }

        [Op]
        static Outcome ParseLineNumber(ReadOnlySpan<char> src, out uint j, out uint dst)
        {
            j=0;
            dst = 0;
            const char Delimiter = Chars.Colon;
            const byte LastIndex = 8;
            const byte ContentLength = 9;
            if(!IsNumbered(src))
                return false;

            var result = Outcome.Failure;
            var storage = CharBlock8.Null;
            var buffer = storage.Data;

            while(j++ <= LastIndex)
            {
                ref readonly var c = ref skip(src, j);
                if(char.IsDigit(c))
                    seek(buffer, j) = c;
                else if(c == Delimiter && j==LastIndex)
                {
                    result = uint.TryParse(buffer, out dst);
                    break;
                }
                else
                    break;
            }
            return result;
        }


        public bool Next(out TextLine dst)
        {
            dst = TextLine.Empty;
            var line = Source.ReadLine();
            if(blank(line))
                return false;

            Consumed++;

            var data = span(line);
            var result = true;
            if(ParseLineNumber(data, out var length, out var number))
                dst = new TextLine(number, line.Substring((int)length));
            else
                dst = new TextLine(Consumed, line);

            return result;
        }
    }
}