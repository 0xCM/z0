//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{

    public interface IBinaryOperator : IOperator
    {
        IOperatorApplication Apply(object Left, object Right);
    }


    public interface IBinaryOperator<T>
    {
        T Apply(T x, T y);
    }

    public interface IBinaryPredicate<T>
    {
        bool Apply(T x, T y);
    }

}