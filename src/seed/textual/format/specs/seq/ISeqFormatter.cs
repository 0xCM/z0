//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ISeqFormatter
    {
        string FormatItem(object src);
    }
    
    public interface ISeqFormatConfig 
    {
        string Delimiter {get;}
    }

    public interface ISeqFormatConfig<C> : ISeqFormatConfig
        where C : struct, ISeqFormatConfig
    {

    }
        
    public interface ISeqFormatter<T> : ISeqFormatter
    {
        string FormatItem(T src)
            => FormatItem(src);

        string ISeqFormatter.FormatItem(object src)
            => FormatItem((T)src);
    }

    public interface ISeqFormatter<T,C> : ISeqFormatter<T>
        where C : ISeqFormatConfig
    {
        
    }  

    public interface ISeqFormatter<T,C,E> : ISeqFormatter<T,C>
        where C : ISeqFormatConfig
    {
        string FormatItem(T src, in E config);
    }  

}