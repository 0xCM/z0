//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IFunctionSurrogate<S,D,A>
        where S : struct, IFunctionSurrogate<S,D,A>
        where D : Delegate
    {


    }

    public interface IFunctionSurrogate<S,D,A,B>
        where S : struct, IFunctionSurrogate<S,D,A,B>
        where D : Delegate
    {


    }


    public interface IUnaryPredicateSurrotate<T> 
        : IFunctionSurrogate<UnaryPredicateSurrogate<T>, UnaryPredicate<T>, IUnaryPredicate<T>>
    {

    }

    public interface IBinaryOpSurrotate<T> 
        : IFunctionSurrogate<BinaryOpSurrogate2<T>, BinaryOp<T>, IBinaryOp<T>>
    {

    }

}