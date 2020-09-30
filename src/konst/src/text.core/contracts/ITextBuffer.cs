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

        void AppendFormat(string pattern, params object[] args)
            => Append(string.Format(pattern, args));
    }

    public interface ITextBuffer<H> : ITextBuffer
        where H : struct, ITextBuffer<H>
    {

    }
}