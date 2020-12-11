//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IParserFactory
    {
        Type SourceType {get;}

        Type TargetType {get;}
    }

    public interface IParserFactory<S,T> : IParserFactory
    {
        Type IParserFactory.SourceType => typeof(S);

        Type IParserFactory.TargetType => typeof(T);
    }
}