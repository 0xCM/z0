//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IParser
    {
        Type SourceType {get;}

        Type TargetType {get;}

        ParseResult Parse(object src);
    }

    public interface IParser<S,T> : IParser
    {
        Type IParser.SourceType
            => typeof(S);

        Type IParser.TargetType
            => typeof(T);

        ParseResult<S,T> Parse(S src);

        ParseResult IParser.Parse(object src)
            => Parse((S)src);

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