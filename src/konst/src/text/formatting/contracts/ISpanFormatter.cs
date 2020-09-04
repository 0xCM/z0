//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISpanFormatter<T> : ISequenceFormatter<T>
    {
        /// <summary>
        /// Formats and concatenates span content
        /// </summary>
        /// <param name="src">The source span</param>
        string Format(ReadOnlySpan<T> src);

        /// <summary>
        /// Formats span cells
        /// </summary>
        /// <param name="src">The source span</param>
        ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src);
    }

   public interface ISpanFormatter<T,C> : ISpanFormatter<T>, ISequenceFormatter<T,C>
        where C : ISeqFormat
    {
        /// <summary>
        /// Formats and concatenates span content using a sequence format configuration
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="config">The sequence format configuration</param>
        string Format(ReadOnlySpan<T> src, in C config);

        /// <summary>
        /// Formats source span cells using a sequence format configuration
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="config">The sequence format configuration</param>
        ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src, in C config);
    }

   public interface ISpanFormatter<T,C,E> : ISpanFormatter<T,C>, ISequenceFormatter<T,C,E>
        where C : ISeqFormat
    {
        /// <summary>
        /// Formats a span using both sequence and element format configurations
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="seq">The sequence format configuration</param>
        /// <param name="config">The element format configuration</param>
        string Format(ReadOnlySpan<T> src, in C seq, in E element);
    }
}