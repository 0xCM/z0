//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public interface ITextBuffer : IBuffered<string,string>
    {
        void AppendLine(string src)
        {
            Append(src);
            Append(Eol);
        }

        void AppendLine()
            => Append(Eol);

        void Append(ReadOnlySpan<char> src)
            => Append(new string(src));

        void Append(char[] src)
            => Append(new string(src));

        void Append(char c)
            => Append(c.ToString());

        void Delimit<F,T>(F field, T value, char c = FieldDelimiter)
            where F : unmanaged
        {
            var shift = bitsize<F>()/2;
            var width = uint32(field) >> shift;
            Append(text.rspace(c));
            Append($"{value}".PadRight((int)width));
        }

        void Delimit<T>(byte width, T value, char c = FieldDelimiter)
            where T : ITextual
        {
            Append(text.rspace(c));
            Append(value.Format().PadRight(width));
        }

        void AppendFormat(string pattern, params object[] args)
            => Append(string.Format(pattern, args));
    }

    public interface ITextBuffer<H> : ITextBuffer
        where H : struct, ITextBuffer<H>
    {

    }
}