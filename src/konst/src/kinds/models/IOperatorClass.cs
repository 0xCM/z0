//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    using static Kinds;

    public interface IOperatorClass<F,E> : IOperatorClass<E>, IOpClassF<F,E>
        where F : struct, IOperatorClass<F,E>
        where E : unmanaged, Enum
    {
        OperatorClass Generalized {get;}
    }

    public interface IOperatorClass<F,E,T> : IOperatorClass<F,E>, IOpClassT<T>
        where F : struct, IOperatorClass<F,E>
        where E : unmanaged, Enum
    {
        new OperatorClass<T> Generalized {get;}

        OperatorClass IOperatorClass<F,E>.Generalized 
            => Generalized;    
    }
}