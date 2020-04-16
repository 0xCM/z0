//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static EvalPackages;

    public interface IBinaryOpEvalService<T> : IService
        where T : unmanaged
    {
        ref readonly BinaryEval<T> Evaluate(in BinaryOpEval<T> package);
    }
}