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

    [Free]
    public interface IParser<S,T> : IParser
    {
        Outcome Parse(in S src, out T dst);

        Type IParser.SourceType
            => typeof(S);

        Type IParser.TargetType
            => typeof(T);

        Outcome<T> Parse(in S src)
        {
            var outcome = Parse(src, out T dst);
            return outcome ? dst : outcome;
        }

        bool Parse(in S src, out T dst, out Outcome result)
        {
            result = Parse(src, out dst);
            return result;
        }
    }

    [Free]
    public interface ITextParser : IParser
    {
        Outcome Parse(string src, out dynamic dst);
    }

    [Free]
    public interface ITextParser<T> : ITextParser, IParser<string,T>
    {
        Outcome ITextParser.Parse(string src, out dynamic dst)
        {
            if(Parse(src, out T value, out var result))
            {
                dst = value;
                return true;
            }
            else
            {
                dst = new object();
                return result;
            }
        }
    }
}