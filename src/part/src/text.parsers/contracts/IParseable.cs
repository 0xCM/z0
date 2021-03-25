//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IParseable
    {
        IParseFunction Parser {get;}
    }

    public interface IParseable<T> : IParseable
    {
        new IParseFunction<T> Parser {get;}

        IParseFunction IParseable.Parser
            => Parser;
    }

    public interface IParseable<K,T> : IParseable<T>
        where K : unmanaged
    {
        new IParseFunction<T,K> Parser {get;}

        IParseFunction<T> IParseable<T>.Parser
            => Parser;
    }
}