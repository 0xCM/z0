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

        object Format(object src);
    }

    public interface IFormatter<S,T> : IFormatter
    {
        Type IFormatter.SourceType
            => typeof(S);

        Type IFormatter.TargetType
            => typeof(Span<byte>);

        T Format(S src);

        object IFormatter.Format(object src)
            => ((S)src);
    }
}