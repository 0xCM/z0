//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public interface IParser
    {
        object Parse(string text);
    }    

    public interface IParser<T> : IParser
    {
        new T Parse(string text);

        object IParser.Parse(string text)
            => Parse(text);
    }
}