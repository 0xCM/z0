//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IOpEvaluator
    {

    }

    public interface IOpEvaluator<T> : IOpEvaluator
        where T : unmanaged

    {

    }

    public interface IBinaryOpEvaluator<T> : IOpEvaluator<T>
        where T : unmanaged
    {
        ref readonly BinaryEvaluations<T> Evaluate(in BinaryEvalContext<T> src);
    }

    public interface IUnaryOpEvaluator<T> : IOpEvaluator<T>
        where T : unmanaged
    {
        ref readonly UnaryEvaluations<T> Evaluate(in UnaryEvalContext<T> src);
    }
}