//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public interface ITextValueFormatter<F,T> : ITextValueFormatter<T>
        where F : unmanaged, Enum
        where T : struct
    {
        void Format(in T src, IDatasetFormatter<F> dst);

        string ITextValueFormatter<T>.Format(in T src)
        {
            var dst = Formatters.dataset<F>();
            Format(src, dst);
            return dst.Render();
        }

        string ITextValueFormatter<T>.HeaderText
            => Formatters.dataset<F>().HeaderText;
    }

    public interface ITextBuffer : IRenderBuffer<string,string>
    {
        void AppendLine(string src)
        {
            Append(src);
            Append(Eol);
        }

        void AppendFormat(string pattern, params object[] args)
        {
            Append(string.Format(pattern, args));
        }

        void Delimit<T>(T src, ushort width)
        {
            var pattern = " | " + text.embrace($"0,-{width}");
            AppendFormat(pattern, src);
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

        void AppendDelimited<T>(T[] src, char c = FieldDelimiter)
            => Append(Seq.delimit(src, c).Format());

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