//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Root;

    [SuppressUnmanagedCodeSecurity]
    public delegate void FixedAction<X0>(X0 x0)
        where X0 : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate void FixedAction<X0,X1>(X0 x0, X1 x1)
        where X0 : IFixed
        where X1 : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate void FixedAction<X0,X1,X2>(X0 x0, X1 x1, X2 x2)
        where X0 : IFixed
        where X1 : IFixed
        where X2 : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedEmitter<R>()
        where R : IFixed;


    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<X0,R>(X0 x0)
        where R : IFixed
        where X0 : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<X0,X1,R>(X0 x0, X1 x1)
        where R : IFixed
        where X1 : IFixed
        where X0 : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<X0,X1,X2,R>(X0 x0, X1 x1, X2 x2)
        where R : IFixed
        where X0 : IFixed
        where X1 : IFixed
        where X2 : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<X0,X1,X2,X3,R>(X0 x0, X1 x1, X2 x2, X3 x3)
        where R : IFixed
        where X0 : IFixed
        where X1 : IFixed
        where X2 : IFixed
        where X3 : IFixed;        


    [SuppressUnmanagedCodeSecurity]
    public delegate F FixedUnaryOp<F>(F a)
        where F : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate F FixedBinaryOp<F>(F a, F b)
        where F : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate F FixedTernaryOp<F>(F a, F b, F c)
        where F : IFixed;
    
    [SuppressUnmanagedCodeSecurity]
    public delegate bit FixedUnaryPred<F>(F a)
        where F : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit FixedBinaryPred<F>(F a, F b)
        where F : IFixed;        

    [SuppressUnmanagedCodeSecurity]
    public delegate bit FixedTernaryPred<F>(F a, F b, F c)
        where F : IFixed;        
}