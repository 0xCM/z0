//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public interface ITextBuffer : IRenderBuffer<string,string>
    {
        void AppendLine(string src)
        {
            Append(src);
            Append(Eol);
        }

        void Append(ReadOnlySpan<char> src)
            => Append(new string(src));

        void Append(char[] src)
            => Append(new string(src));

        void Append(char c)
            => Append(c.ToString());

        void AppendLine<T>(T src)
        {
            if(src != null)
            {
                Append(src.ToString());
                Append(Eol);
            }
        }

        void AppendLine()
            => Append(Eol);

        void AppendDelimited<F,T>(F field, T value, char c = FieldDelimiter)
            where F : unmanaged
        {
            var shift = bitsize<F>()/2;
            var width = uint32(field) >> shift;
            Append(text.rspace(c));
            Append($"{value}".PadRight((int)width));
        }

        void AppendDelimited<T>(byte width, T value, char c = FieldDelimiter)
            where T : ITextual
        {
            Append(text.rspace(c));
            Append(value.Format().PadRight(width));
        }

        void AppendDelimited<T>(T[] src, char c = FieldDelimiter)
            => Append(delimit(src, c).Format());

        void AppendFormatted(string pattern, params object[] args)
            => Append(string.Format(pattern, args));

        void AppendSettingLine(string name, object value)
        {
            AppendFormatted("{0}:{1}", name, value);
            AppendLine();
        }

        void AppendFormattedLine(string pattern, params object[] args)
        {
            AppendFormatted(pattern, args);
            Append(Eol);
        }
    }

    public interface ITextBuffer<H> : ITextBuffer, IService<H,ITextBuffer>
        where H : struct, ITextBuffer<H>
    {

    }
}