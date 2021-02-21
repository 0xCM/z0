//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public interface ITextBuffer : IRenderBuffer<string,string>
    {
        void AppendLine(string src)
        {
            Append(src);
            Append(Eol);
        }

        void AppendSpace()
        {
            Append(Space);
        }

        void AppendLine()
            => Append(Eol);

        void AppendFormat(string pattern, params object[] args)
            => Append(string.Format(pattern, args));

        void AppendLineFormat(string pattern, params object[] args)
            => AppendLine(string.Format(pattern, args));

        void AppendLine<T>(PropFormat<T> src)
            => AppendLine(src.Format());

        void Append(ReadOnlySpan<char> src)
            => Append(new string(src));

        void Append(char[] src)
            => Append(new string(src));

        void Append(char c)
            => Append(c.ToString());

        void AppendItem<T>(T src)
            => Append(src?.ToString() ?? "!<null>!");

        void AppendLine<T>(T src)
        {
            if(src != null)
            {
                Append(src.ToString());
                Append(Eol);
            }
        }

        void Indent<T>(uint margin, T src)
            => Append(string.Format("{0}{1}", new string(Chars.Space, (int)margin), src));

        void IndentLine<T>(uint margin, T src)
            => AppendLine(string.Format("{0}{1}", new string(Chars.Space, (int)margin), src));

        void AppendDelimited(string delimiter, params object[] src)
        {
            var count = src.Length;
            var terms = @readonly(src);
            var sep = string.Format("{0} ", delimiter);
            for(var i=0; i<src.Length; i++)
                Append(string.Format("{0}{1}", sep, skip(terms,i)));
        }

        void AppendDelimited<F,T>(F field, T value, char c = FieldDelimiter)
            where F : unmanaged
        {
            var shift = width<F>()/2;
            var width = uint32(field) >> shift;
            Append(text.rspace(c));
            Append($"{value}".PadRight((int)width));
        }

        void AppendValue<T>(T value, uint width, char c = FieldDelimiter)
            where T : struct
        {
            Append(text.rspace(c));
            Append(value.ToString().PadRight((int)width));
        }

        void Append(string value, uint width, char c = FieldDelimiter)
        {
            if(text.nonempty(value))
            {
                Append(text.rspace(c));
                Append(value.PadRight((int)width));
            }
        }

        void AppendFormatted(string pattern, params object[] args)
            => Append(string.Format(pattern, args));
    }

    public interface ITextBuffer<H> : ITextBuffer, IService<H,ITextBuffer>
        where H : struct, ITextBuffer<H>
    {

    }
}