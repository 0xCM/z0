//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;


    [SuppressUnmanagedCodeSecurity]
    public interface IPointedSurrogate<D,R>
        where D : Delegate
        where R : unmanaged, IPoint

    {
        R Evaluate();
        
        PointEvaluator<R> Evaluator
            => Evaluate;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IPointedSurrogate<D,X,R>
        where D : Delegate
        where X : unmanaged, IPoint
        where R : unmanaged, IPoint

    {
        R Evaluate(in X x);

        PointEvaluator<X,R> Evaluator
            => Evaluate;
    }
}