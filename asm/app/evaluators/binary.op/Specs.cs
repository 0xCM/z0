//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;

    using static EvalPackages;
    using static OpClasses;

    public interface IBinaryOpEvaluator<T> : IApiEvaluator<BinaryOp, T>
        where T : unmanaged
    {
        ref readonly PairEval<T> Evaluate(in BinaryOpPackage<T> package);
    }
}