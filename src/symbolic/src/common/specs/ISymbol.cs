//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ISymbol
    {
        char Value {get;}
    }

    public interface ISymbol<F,E> : ISymbol
        where E : unmanaged, Enum    
        where F : unmanaged, ISymbol<F,E>
    {
        new E Value {get;}
    }

    public interface ISymbol<F,E,T> : ISymbol<F,E>
        where E : unmanaged, Enum    
        where F : unmanaged, ISymbol<F,E,T>
        where T : unmanaged
    {
        T Data {get;}
    }

}