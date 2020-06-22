//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IOpEvaluator<T>
        where T : unmanaged

    {

    }

    public interface IBinaryOpEvaluator<T> : IOpEvaluator<T>
        where T : unmanaged
    {
        ref readonly BinaryEval<T> Evaluate(in BinaryOpEval<T> src);
    }

    public interface IUnaryOpEvaluator<T> : IOpEvaluator<T>
        where T : unmanaged
    {
        ref readonly UnaryEval<T> Evaluate(in UnaryOpEval<T> src);
    }    
}