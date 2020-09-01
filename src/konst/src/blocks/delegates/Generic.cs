//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedEmitter<R>()
        where R : IFixedCell;

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<X0,R>(X0 x0);

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<X0,X1,R>(X0 x0, X1 x1);

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<X0,X1,X2,R>(X0 x0, X1 x1, X2 x2);

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedFunc<X0,X1,X2,X3,R>(X0 x0, X1 x1, X2 x2, X3 x3);

    [SuppressUnmanagedCodeSecurity]
    public delegate F FixedUnaryOp<F>(F a);

    [SuppressUnmanagedCodeSecurity]
    public delegate F FixedBinaryOp<F>(F a, F b);

    [SuppressUnmanagedCodeSecurity]
    public delegate F FixedTernaryOp<F>(F a, F b, F c);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit FixedUnaryPred<F>(F a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit FixedBinaryPred<F>(F a, F b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit FixedTernaryPred<F>(F a, F b, F c);

    [SuppressUnmanagedCodeSecurity]
    public delegate void FixedAction<X0>(X0 x0);

    [SuppressUnmanagedCodeSecurity]
    public delegate void FixedAction<X0,X1>(X0 x0, X1 x1);

    [SuppressUnmanagedCodeSecurity]
    public delegate void FixedAction<X0,X1,X2>(X0 x0, X1 x1, X2 x2);
}