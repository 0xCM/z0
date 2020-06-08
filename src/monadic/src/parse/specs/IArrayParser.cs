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

    public interface IArrayParser<P,S,T> : IStreamParser<P,S,T>
        where P : IParser<S,T>
    {
        ParseResult<S,T>[] Parse(params S[] src)
            => (this as IStreamParser<P,S,T>).Parse(src).ToArray();
    }

    public interface ICellularPaser<S,T> : IParser<S,T[]>
        where T : unmanaged
    {

    }
}