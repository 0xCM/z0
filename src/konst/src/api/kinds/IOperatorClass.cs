//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public interface IOperatorClass : IOpClass
    {
        
    }

    public interface IOperatorClass<E> : IOperatorClass, IOpClass<E>
        where E : unmanaged, Enum
    {
        
    }
}