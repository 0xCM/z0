//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static RootShare;

   public interface ISpanFormatter<T> : ISequenceFormatter<T>
        where T : IFormattable<T>
    {
        string Format(ReadOnlySpan<T> src);

        ReadOnlySpan<string> FormatElements(ReadOnlySpan<T> src);
    }

   public interface IStreamFormatter<T> : ISequenceFormatter<T>
        where T : IFormattable<T>
    {
        string Format(IEnumerable<T> src);

        IEnumerable<string> FormatElements(IEnumerable<T> src);
    }

   public interface IArrayFormatter<T> : ISequenceFormatter<T>
        where T : IFormattable<T>
    {
        string Format(T[] src);

        string[] FormatElements(T[] src);
    }
}