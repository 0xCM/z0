//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IMatcher
    {

    }

    public interface IMatcher<T> : IMatcher
    {
        ReadOnlySpan<MatchResult> Match(ReadOnlySpan<T> src);
    }
}