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

        const byte NumberWidth = TextLine.NumberWidth;

        const char Delimiter = TextLine.Delimiter;

        [Op]
        static Outcome LineNumber(ReadOnlySpan<char> src, out uint dst)
        {
            dst = uint.MaxValue;
            var length = src.Length;
            if(length > NumberWidth)
            {
                ref readonly var c = ref skip(src, NumberWidth + 1);
                if(c == Delimiter && SymbolicQuery.digits(base10, src,0, NumberWidth))
                {
                    if(uint.TryParse(src, out var number))
                    {
                        dst = number;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Next(out TextLine dst)
        {
            var next = Source.ReadLine();
            var data = span(next);
            var result = true;
            dst = TextLine.Empty;

            if(next == null)
                return false;

            if(next != null)
            {
                Consumed++;

                var length = next.Length;
                if(length == 0)
                    return true;

                if(LineNumber(data, out var number))
                    dst = new TextLine(number, next.Substring(NumberWidth + 1));
                else
                    dst = new TextLine(Consumed, next);
            }

            return result;
        }
    }
}