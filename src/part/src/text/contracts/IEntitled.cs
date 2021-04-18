//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a content formatter that can also produces titles and titled content
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEntitled<T> : ITitleFormatter<T>, ITextFormatter<T>
    {
        ITextFormatter<T> ContentFormatter {get;}

        ITitleFormatter<T> TitleFormatter {get;}

        string IFormatter<T,string>.Format(T src)
            => ContentFormatter.Format(src);

        string ITitleFormatter<T>.FormatTitle(T src)
            => TitleFormatter.FormatTitle(src);

        string FormatEntitled(T src)
            => String.Concat(FormatTitle(src), Chars.FSlash, ContentFormatter.Format(src));
    }
}