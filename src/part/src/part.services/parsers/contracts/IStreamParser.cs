//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public interface IStreamParser<P,T> : ITextParser<T>
        where P : ITextParser<T>
    {
        IEnumerable<ParseResult<T>> Parse(IEnumerable<string> src)
            => src.Select(Parse);
    }
}