//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IParseFunction
    {
        Type TargetType {get;}

        bool Parse(string src, out dynamic dst);
    }

    public interface IParseFunction<T> : IParseFunction
    {
        Outcome Parse(string src, out T dst);

        Type IParseFunction.TargetType
            => typeof(T);

        bool IParseFunction.Parse(string src, out dynamic dst)
        {
            var target = default(T);
            var result = Parse(src, out target);
            dst = target;
            return result;
        }
    }
}