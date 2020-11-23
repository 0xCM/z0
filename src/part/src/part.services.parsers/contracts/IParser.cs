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
    }

    public interface IParser<S,T> : IParser
    {
        Type IParser.SourceType
            => typeof(S);

        Type IParser.TargetType
            => typeof(T);

        ParseResult<S,T> Parse(S src);
    }

    public interface IParser2<S,T> : IParser<S,T>
    {
        ParseResult2<S> Parse(in S src, out T dst);

        ParseResult<S,T> IParser<S,T>.Parse(S src)
        {
            var x = Parse(src, out var dst);
            if(x)
                return ParseResult<S,T>.Success(src, dst);
            else
                return ParseResult<S,T>.Fail(src, x.Message);
        }
    }

    [Free]
    public interface ITextParser2<T> : IParser2<string,T>
    {
        ParseResult2<string> Parse(string src, out T dst);

        ParseResult2<string> IParser2<string,T>.Parse(in string src, out T dst)
            => Parse(src, out dst);
    }
}