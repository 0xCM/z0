//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface ISeqFormatter
    {
        string FormatItem(object src);
    }
    
    public interface ISeqFormatter<T> : ISeqFormatter
    {
        [MethodImpl(Inline)]
        string FormatItem(T src)
            => FormatItem(src);

        [MethodImpl(Inline)]
        string ISeqFormatter.FormatItem(object src)
            => FormatItem((T)src);
    }

    public interface ISeqFormatter<T,C> : ISeqFormatter<T>
        where C : ISeqFormatConfig
    {
        
    }  

    public interface ISeqFormatter<T,C,E> : ISeqFormatter<T,C>
        where C : ISeqFormatConfig
        where E : IFormatConfig
    {
        string FormatItem(T src, in E config);
    }  


    public interface IElementConfiguredSeqFormatter<T,C> : ISeqFormatter<T,C>
        where T : IConfiguredFormattable
        where C : ISeqFormatConfig
    {
        string FormatItem(T src, IFormatConfig c)
            => src.Format(c);
    }      

    public interface IElementConfiguredSeqFormatter<T,C,E> : IElementConfiguredSeqFormatter<T,C>
        where T : IConfiguredFormattable
        where C : ISeqFormatConfig
        where E : IFormatConfig
    {
        string FormatItem(T src, in E c)
            => src.Format(c);

        [MethodImpl(Inline)]
        string IElementConfiguredSeqFormatter<T,C>.FormatItem(T src, IFormatConfig c)
            => FormatItem(src, (C)c);
    }      
}