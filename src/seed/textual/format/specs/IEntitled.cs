//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Characterizes a content formatter that can also produces titles and titled content
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEntitled<T> : ITitleFormatter<T>, IFormatter<T>
    {
        IFormatter<T> ContentFormatter {get;}

        ITitleFormatter<T> TitleFormatter {get;}

        [MethodImpl(Inline)]
        string IFormatter<T>.Format(T src) 
            => ContentFormatter.Format(src);

        [MethodImpl(Inline)]
        string ITitleFormatter<T>.FormatTitle(T src)
            => TitleFormatter.FormatTitle(src);

        [MethodImpl(Inline)]
        string FormatEntitled(T src)
            => String.Concat(
                FormatTitle(src), 
                Chars.FSlash, 
                ContentFormatter.Format(src)
                );
    }
}