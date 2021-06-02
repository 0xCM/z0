//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using static Root;

    public interface ITextBuffer : IRenderBuffer<string,string>
    {
        void AppendLine();

        void Append(ReadOnlySpan<char> src);

        void Append(char[] src);

        void AppendFormat(string pattern, params object[] args);

        void Append(char c);

        StringBuilder ToStringBuilder();

        void AppendLine(string src);

        void AppendLine<T>(T src);

        void AppendLineFormat(string pattern, params object[] args);

        void IndentLine<T>(uint margin, T src);

        void AppendItem<T>(T src);

        void AppendDelimited(string delimiter, params object[] src);

        void AppendPadded<T,W>(T value, W width, string delimiter = EmptyString);

        void AppendDelimited<F,T>(F field, T value, char c = FieldDelimiter)
            where F : unmanaged;

        void AppendSpace()
            => Append(Space);
    }

    public interface ITextBuffer<H> : ITextBuffer
        where H : ITextBuffer<H>
    {

    }
}