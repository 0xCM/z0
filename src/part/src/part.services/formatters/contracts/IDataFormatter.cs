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
        Type ITransformer.SourceType
            => typeof(S);

        Type ITransformer.TargetType
            => typeof(Span<byte>);

        Span<byte> Format(in S src);
    }
}