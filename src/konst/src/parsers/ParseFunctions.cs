//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public readonly struct ParseFunctions
    {
        [Free]
        public delegate bool Canonical<S,T>(in S src, out T dst);


        [Free]
        public interface ICanonical<S,T> : IParseFunction<S,T>
        {
            bool Parse(in S src, out T dst);
        }
    }

    [Free]
    public interface IParseFunction
    {
        Type SourceType {get;}

        Type TargetType {get;}
    }

    [Free]
    public interface IParseFunction<S,T> : IParseFunction
    {
        Type IParseFunction.SourceType => typeof(S);

        Type IParseFunction.TargetType => typeof(T);
    }
}