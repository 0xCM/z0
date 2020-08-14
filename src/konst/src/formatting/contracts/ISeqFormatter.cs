//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISequenceFormatter
    {
        string FormatItem(object src);
    }
                       
    public interface ISequenceFormatter<T> : ISequenceFormatter
    {
        string FormatItem(T src)
            => FormatItem(src);

        string ISequenceFormatter.FormatItem(object src)
            => FormatItem((T)src);
    }

    public interface ISequenceFormatter<T,C> : ISequenceFormatter<T>
        where C : ISequenceFormatConfig
    {
        
    }  

    public interface ISequenceFormatter<T,C,E> : ISequenceFormatter<T,C>
        where C : ISequenceFormatConfig
    {
        string FormatItem(T src, in E config);
    }  
}