//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public interface IArrayParser<P,T> : IStreamParser<P,T>
        where P : ITextParser<T>
    {
        ParseResult<T>[] Parse(params string[] src)
            => (this as IStreamParser<P,T>).Parse(src).ToArray();
    }


}