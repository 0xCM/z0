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

    public interface IFormatter<S> : IFormatter
    {
        Type IFormatter.SourceType
            => typeof(S);

        Type IFormatter.TargetType
            => typeof(Span<byte>);

        Span<byte> Format(in S src);
    }

    public interface IFormatter<S,T> : IFormatter
    {
        T Format(S src);

        Type IFormatter.SourceType
            => typeof(S);

        Type IFormatter.TargetType
            => typeof(T);
    }
}