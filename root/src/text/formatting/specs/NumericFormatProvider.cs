//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface INumericFormatProvider<T> :  IFormatProvider<T>
        where T : unmanaged
    {
        new INumericFormatter<T> Formatter {get;}

        IFormatter<T> IFormatProvider<T>.Formatter
            => Formatter;

    }

    public interface INumericFormatProvider<F,T> : INumericFormatProvider<T>
        where T : unmanaged
    {

    }
}