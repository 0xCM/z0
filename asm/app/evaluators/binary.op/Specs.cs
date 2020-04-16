//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static EvalPackages;

    public interface IBinaryOpEvaluator<T> : IService
        where T : unmanaged
    {
        ref readonly BinaryEval<T> Evaluate(in BinaryOpPackage<T> package);
    }
}