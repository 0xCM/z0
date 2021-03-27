//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using static Part;
    using static memory;

    public interface ITextBuffer : IRenderBuffer<string,string>
    {
        StringBuilder ToStringBuilder();

        void AppendLine(string src)
        {
            Append(src);
            Append(Eol);
        }

        void AppendLine<T>(T src)
        {
            if(src != null)
            {
                Append(src.ToString());
                Append(Eol);
            }
        }

        void AppendSpace()
        {
            Append(Space);
        }

        void AppendLine()
            => Append(Eol);

        void AppendLineFormat(string pattern, params object[] args)
            => AppendLine(string.Format(pattern, args));

        void IndentLine<T>(uint margin, T src)
            => AppendLine(string.Format("{0}{1}", new string(Chars.Space, (int)margin), src));

        void AppendFormat(string pattern, params object[] args)
            => Append(string.Format(pattern, args));

        void Append(ReadOnlySpan<char> src)
            => Append(new string(src));

        void Append(char[] src)
            => Append(new string(src));

        void Append(char c)
            => Append(c.ToString());

        void AppendItem<T>(T src)
            => Append(src?.ToString() ?? "!<null>!");

        void AppendDelimited(string delimiter, params object[] src)
        {
            var count = src.Length;
            var terms = @readonly(src);
            var sep = string.Format("{0} ", delimiter);
            for(var i=0; i<src.Length; i++)
                Append(string.Format("{0}{1}", sep, skip(terms,i)));
        }

        void AppendPadded<T,W>(T value, W width, string delimiter = EmptyString)
        {
            if(text.nonempty(delimiter))
                Append(delimiter);

            Append(string.Format(RP.pad(-i16(width)), value));
        }

        void AppendDelimited<F,T>(F field, T value, char c = FieldDelimiter)
            where F : unmanaged
        {
            var shift = width<F>()/2;
            var width = uint32(field) >> shift;
            Append(text.rspace(c));
            Append($"{value}".PadRight((int)width));
        }

        void AppendFormatted(string pattern, params object[] args)
            => Append(string.Format(pattern, args));
    }

    public interface ITextBuffer<H> : ITextBuffer, IService<H,ITextBuffer>
        where H : struct, ITextBuffer<H>
    {

    }
}