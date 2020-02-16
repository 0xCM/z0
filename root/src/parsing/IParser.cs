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
        ParseResult Parse(string text);
    }    

    public interface IParser<T> : IParser
    {
        new ParseResult<T> Parse(string text);

        ParseResult IParser.Parse(string text)
            => Parse(text);
    }
}