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
    public interface IOperatorClassHost<F,E> : IOperatorClass<E>, IOperationalClassHost<F,E>
        where F : struct, IOperatorClassHost<F,E>
        where E : unmanaged, Enum
    {
        OperatorClass Classifier {get;}
    }

    [Free]
    public interface IOperatorClassHost<F,E,T> : IOperatorClassHost<F,E>, IClassT<T>
        where F : struct, IOperatorClassHost<F,E>
        where E : unmanaged, Enum
    {
        new OperatorClass<T> Classifier {get;}

        OperatorClass IOperatorClassHost<F,E>.Classifier
            => Classifier;
    }
}