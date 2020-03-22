//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IOpClass : IClass
    {

    }

    public interface IOpClass<E> : IOpClass 
        where E : unmanaged, Enum
    {
        E Class {get;}

        string Name => Class.ToString().ToLower();
        
    }

    public interface IOpClass<E,T> : IOpClass<E>
        where T : unmanaged
        where E : unmanaged, Enum
    {

    }
}