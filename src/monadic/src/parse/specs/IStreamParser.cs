//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

   public interface IStreamParser<P,T> : ITextParser<T>
        where P : ITextParser<T>
    {
        IEnumerable<ParseResult<T>> Parse(IEnumerable<string> src)
            => src.Select(Parse);
    }

   public interface IStreamParser<P,S,T> : IParser<S,T>
        where P : IParser<S,T>
    {
        IEnumerable<ParseResult<S,T>> Parse(IEnumerable<S> src)
            => src.Select(Parse);
    }

}