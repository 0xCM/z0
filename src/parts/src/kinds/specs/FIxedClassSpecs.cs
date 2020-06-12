//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFixedOpClass : IOpClass
    {
        TypeWidth Width {get;}
    }

    public interface IFixedOpClass<E> : IFixedOpClass, IOpClass<E>
        where E : unmanaged, Enum
    {
        
    }

    public interface IFixedOpClassF<F,E> : IFixedOpClass<E>
        where F : struct, IFixedOpClassF<F,E>
        where E : unmanaged, Enum
    {
        
    }    
}