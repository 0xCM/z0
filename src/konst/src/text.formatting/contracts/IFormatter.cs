//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a text serializer
    /// </summary>
    public interface IFormatter
    {
        Type SourceType {get;}

        Type TargetType {get;}
    }

    public interface IFormatter<S,T> : IFormatter
    {
        T Format(S src);

        Type IFormatter.SourceType => typeof(S);

        Type IFormatter.TargetType => typeof(T);
    }

    public interface IFormatter<H,S,T> : IFormatter<S,T>, IService<H,IFormatter<S,T>,S,T>
        where H : IFormatter<H,S,T>
    {

    }
}