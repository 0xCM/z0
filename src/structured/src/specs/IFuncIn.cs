//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.Intrinsics;

    public delegate R FuncIn<A,R>(in A a);

    public delegate R FuncIn<A,B,R>(in A a, in B b);

    public delegate R FuncIn<A,B,C,R>(in A a, in B b, in C c);

    public interface IFuncD<D> : IFunc
        where D : Delegate
    {
        D Operation {get;}
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFuncIn<A,R> : IFuncD<FuncIn<A,R>>
    {
        R Invoke(in A a);

        FuncIn<A,R>  IFuncD<FuncIn<A,R>>.Operation => Invoke;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFuncIn<A,B,R> : IFuncD<FuncIn<A,B,R>>
    {
        R Invoke(in A a, in B b);

        FuncIn<A,B,R> IFuncD<FuncIn<A,B,R>>.Operation => Invoke;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFuncIn<A,B,C,R> : IFuncD<FuncIn<A,B,C,R>>
    {
        R Invoke(in A a, in B b, in C c);

        FuncIn<A,B,C,R> IFuncD<FuncIn<A,B,C,R>>.Operation => Invoke;
    }
}