//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITextFormatter
    {
        string Format(object src);
    }

    public interface ITextFormatter<T> : ITextFormatter
    {
        string ITextFormatter.Format(object src)
            => Format(src);
    }
}