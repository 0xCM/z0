//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface ISpanFormatter<T> : ISeqFormatter<T>
    {
        string Format(ReadOnlySpan<T> src);
        
        ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src);
    }

   public interface ISpanFormatter<T,C> : ISpanFormatter<T>, ISeqFormatter<T,C>
        where C : ISeqFormatConfig
    {
        string Format(ReadOnlySpan<T> src, in C config);

        ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src, in C config);

    }

   public interface ISpanFormatter<T,C,E> : ISpanFormatter<T,C>, ISeqFormatter<T,C,E>
        where C : ISeqFormatConfig
        where E : IFormatConfig
    {
         
    }

   public interface IElementConfiguredSpanFormatter<T,C> : ISpanFormatter<T>, IElementConfiguredSeqFormatter<T,C>
        where T : IConfiguredFormattable
        where C : ISeqFormatConfig
    {
        string Format(ReadOnlySpan<T> src, in C config);

        ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src, in C config);

    }

   public interface IElementConfiguredSpanFormatter<T,C,E> : IElementConfiguredSpanFormatter<T,C>, IElementConfiguredSeqFormatter<T,C,E>
        where T : IConfiguredFormattable
        where C : ISeqFormatConfig
        where E : IFormatConfig
    {

        string Format(ReadOnlySpan<T> src, in C seqconfig, in E itemconfig);

        ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src, in C seqconfig, in E itemconfig);
    }
}