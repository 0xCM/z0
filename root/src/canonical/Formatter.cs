//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface ICustomFormatter
    {

    }

    public interface ICustomFormatter<T> : ICustomFormatter
    {
        string Format(T src);
    }

    public interface ICustomFormatter<T,C> : ICustomFormatter<T>
        where C : IFormatConfig
    {
        string Format(T src, C config);        

    }

}