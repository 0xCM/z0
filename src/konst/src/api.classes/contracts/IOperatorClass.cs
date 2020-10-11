//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Konst;

    [Free]
    public interface IOperatorClass : IOperational
    {

    }

    [Free]
    public interface IOperatorClass<E> : IOperatorClass, IOperational<E>
        where E : unmanaged, Enum
    {

    }

    [Free]
    public interface IOperatorClass<F,E> : IOperatorClass<E>, IOperationalF<F,E>
        where F : struct, IOperatorClass<F,E>
        where E : unmanaged, Enum
    {
        OperatorClass Generalized {get;}
    }

    [Free]
    public interface IOperatorClass<F,E,T> : IOperatorClass<F,E>, IOperationalT<T>
        where F : struct, IOperatorClass<F,E>
        where E : unmanaged, Enum
    {
        new OperatorClass<T> Generalized {get;}

        OperatorClass IOperatorClass<F,E>.Generalized
            => Generalized;
    }
}