//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFieldParser
    {
        Type SourceType {get;}

        Type TargetType {get;}

        Outcome<object> Parse(object src);
    }

    public interface IFieldParser<S,T> : IFieldParser
    {
        Type IFieldParser.SourceType => typeof(S);

        Type IFieldParser.TargetType => typeof(T);

        Outcome Parse(in S src, out T dst);

        Outcome<object> IFieldParser.Parse(object src)
        {
            var result = Parse(((S)src), out var dst);
            if(result)
                return (object)dst;
            else
                return result;
        }
    }
}