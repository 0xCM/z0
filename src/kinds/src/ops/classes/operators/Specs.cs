//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IOperatorClass : IOpClass
    {
        
    }

    public interface IOperatorClass<E> : IOperatorClass, IOpClass<E>
        where E : unmanaged, Enum
    {
        
    }

    public interface IOperatorClass<F,E> : IOperatorClass<E>, IOpClassF<F,E>
        where F : struct, IOperatorClass<F,E>
        where E : unmanaged, Enum
    {
        Kinds.OperatorClass Generalized {get;}
    }

    public interface IOperatorClass<F,E,T> : IOperatorClass<F,E>, IOpClassT<T>
        where F : struct, IOperatorClass<F,E>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        new Kinds.OperatorClass<T> Generalized {get;}

        Kinds.OperatorClass IOperatorClass<F,E>.Generalized => Generalized;    
    }
}