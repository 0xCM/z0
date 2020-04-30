//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IOpEvaluator<T> : IService
        where T : unmanaged

    {

    }

    public interface IBinaryOpEvaluator<T> : IOpEvaluator<T>
        where T : unmanaged
    {
        ref readonly BinaryEval<T> Evaluate(in BinaryOpEval<T> package);
    }

    public interface IUnaryOpEvaluator<T> : IOpEvaluator<T>
        where T : unmanaged
    {
        ref readonly UnaryEval<T> Evaluate(in UnaryOpEval<T> package);
    }    
}