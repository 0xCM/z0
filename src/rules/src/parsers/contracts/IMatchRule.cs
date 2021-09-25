//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IMatchRule
    {
        ulong OpCode {get;}
    }

    public interface IMatchRule<T> : IMatchRule
    {
        MatchResult Eval(ReadOnlySpan<T> src);
    }
}