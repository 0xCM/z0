//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITextFormatter : IFormatter
    {
        new string Format(object src);

        Type IFormatter.TargetType => typeof(string);

        object IFormatter.Format(object src)
            => Format(src);
    }

    public interface ITextFormatter<T> : ITextFormatter, IFormatter<T,string>
    {
        Type IFormatter.TargetType => typeof(string);

        Type IFormatter.SourceType => typeof(T);

        object IFormatter.Format(object src)
            => Format(src);

        string ITextFormatter.Format(object src)
            => Format(src);
    }

    public interface ITextFormatter<H,S> : ITextFormatter<S>
        where H : ITextFormatter<H,S>
    {

    }
}