//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    public interface IOperatorClass<F,E> : IOperatorClass<E>, IOpClassF<F,E>
        where F : struct, IOperatorClass<F,E>
        where E : unmanaged, Enum
    {
        Kinds.OperatorClass Generalized {get;}
    }

    public interface IOperatorClass<F,E,T> : IOperatorClass<F,E>, IOpClassT<T>
        where F : struct, IOperatorClass<F,E>
        where E : unmanaged, Enum
    {
        new Kinds.OperatorClass<T> Generalized {get;}

        Kinds.OperatorClass IOperatorClass<F,E>.Generalized 
            => Generalized;    
    }
}