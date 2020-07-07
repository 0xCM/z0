//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using api = Evaluate;

    public interface TBinaryOpEvaluator<T> : IBinaryOpEvaluator<T>
        where T : unmanaged
    {
        ref readonly BinaryEvaluations<T> IBinaryOpEvaluator<T>.Evaluate(in BinaryEvalContext<T> exchange)
            => ref api.compute(exchange);
    }
}