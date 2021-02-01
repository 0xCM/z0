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
        {
            Append(string.Format(pattern, args));
        }

        void Append(ReadOnlySpan<char> src)
            => Append(new string(src));

        void Append(char[] src)
            => Append(new string(src));

        void Append(char c)
            => Append(c.ToString());

        void AppendCell<T>(T src)
            => Append(src?.ToString());

        void AppendLine<T>(T src)
        {
            if(src != null)
            {
                Append(src.ToString());
                Append(Eol);
            }
        }

        void Indent<T>(uint margin, T src)
        {
            var indent = new string(Chars.Space, (int)margin);
            Append(string.Format("{0}{1}",indent, src));
        }

        void IndentLine<T>(uint margin, T src)
        {
            var indent = new string(Chars.Space, (int)margin);
            AppendLine(string.Format("{0}{1}",indent, src));
        }

        void AppendDelimited(char delimiter, params string[] src)
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
            var shift = bitsize<F>()/2;
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

        void AppendSettingLine(string name, object value)
        {
            AppendFormatted("{0}:{1}", name, value);
            AppendLine();
        }
    }

    public interface ITextBuffer<H> : ITextBuffer, IService<H,ITextBuffer>
        where H : struct, ITextBuffer<H>
    {

    }
}