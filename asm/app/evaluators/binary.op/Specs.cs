//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;

    using static EvalPackages;
    using static OpClass;

    public interface IBinaryOpEvaluator<T> : IApiEvaluator<BinaryOp, T>
        where T : unmanaged
    {
        ref readonly BinaryEval<T> Evaluate(in BinaryOpPackage<T> package);
    }
}