//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IEvaluator
    {

    }

    public interface IEvaluator<T> : IEvaluator
    {
        void Evaluate(ReadOnlySpan<T> src);
    }
}