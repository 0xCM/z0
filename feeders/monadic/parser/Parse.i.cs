//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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

    public interface IParser<P,T> : IParser<T>
        where P : IParser<P,T>, new()
    {
        
    }

    public interface IParseResult : IMonadic
    {
        Type TargetType {get;}

        bool Succeeded {get;}

        object Value {get;}
    }

    public interface IParseResult<T> : IParseResult
    {
        Type IParseResult.TargetType
            => typeof(T);

        object IParseResult.Value
            => Value;

        new T Value {get;}
    }    
}