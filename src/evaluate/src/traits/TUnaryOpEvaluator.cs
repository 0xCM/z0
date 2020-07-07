//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using api = Evaluate;

    public interface TUnaryOpEvaluator<T> : IUnaryOpEvaluator<T>
        where T : unmanaged
    {
        ref readonly UnaryEvaluations<T> IUnaryOpEvaluator<T>.Evaluate(in UnaryEvalContext<T> exchange)
            => ref api.compute(exchange);
    }
}