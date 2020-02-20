//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public interface INumericFormatProvider<T> :  IFormatProvider<T>
    {
        new INumericFormatter<T> Formatter {get;}

        IFormatter<T> IFormatProvider<T>.Formatter
            => Formatter;
    }
}