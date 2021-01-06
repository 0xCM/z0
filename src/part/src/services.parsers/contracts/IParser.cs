//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IParser : ITransformer
    {
        ParseResult Parse(object src);
    }

    public interface IParser<S,T> : IParser, ITransformer<S,T>
    {
        ParseResult<S,T> Parse(S src);

        ParseResult IParser.Parse(object src)
            => Parse((S)src);

        bool ITransformer<S,T>.Transform(in S src, out T dst)
            => Parse(src, out dst);

        bool Parse(in S src, out T dst)
        {
            var adapter = new ParseAdapter<S,T>(this);
            return adapter.Parse(src, out dst);
        }

        bool Parse(in S src, out T dst, out string message)
        {
            var adapter = new ParseAdapter<S,T>(this);
            return adapter.Parse(src, out dst, out message);
        }

        T Succeed(in S src, T @default)
            => new ParseAdapter<S,T>(this).Succeed(src, @default);
    }
}