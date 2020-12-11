//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface DataFormatter<S> : IFormatter
        where S : struct
    {
        Type IFormatter.SourceType
            => typeof(S);

        Type IFormatter.TargetType
            => typeof(Span<byte>);

        Span<byte> Format(in S src);
    }
}