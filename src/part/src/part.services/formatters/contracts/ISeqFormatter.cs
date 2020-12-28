//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISeqFormatter
    {
        string FormatItem(object src);
    }

    public interface ISeqFormatter<T> : ISeqFormatter
    {
        string FormatItem(T src)
            => FormatItem(src);

        string ISeqFormatter.FormatItem(object src)
            => FormatItem((T)src);
    }

    public interface ISeqFormatter<T,C> : ISeqFormatter<T>
        where C : ISeqFormatSpec
    {

    }

    public interface ISeqFormatter<T,C,E> : ISeqFormatter<T,C>
        where C : ISeqFormatSpec
    {
        string FormatItem(T src, in E config);
    }
}