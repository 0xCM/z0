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
    public interface IOperatorClass : IOperationalClass
    {

    }

    [Free]
    public interface IOperatorClass<E> : IOperatorClass, IOperationalClass<E>
        where E : unmanaged, Enum
    {

    }
}