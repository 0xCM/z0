//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate R FixedEmitter<R>()
        where R : IDataCell;

    [Free]
    public delegate R FixedFunc<X0,R>(X0 x0);

    [Free]
    public delegate R FixedFunc<X0,X1,R>(X0 x0, X1 x1);

    [Free]
    public delegate R FixedFunc<X0,X1,X2,R>(X0 x0, X1 x1, X2 x2);

    [Free]
    public delegate R FixedFunc<X0,X1,X2,X3,R>(X0 x0, X1 x1, X2 x2, X3 x3);

    [Free]
    public delegate F FixedUnaryOp<F>(F a);

    [Free]
    public delegate F FixedBinaryOp<F>(F a, F b);

    [Free]
    public delegate F FixedTernaryOp<F>(F a, F b, F c);

    [Free]
    public delegate bit FixedUnaryPred<F>(F a);

    [Free]
    public delegate bit FixedBinaryPred<F>(F a, F b);

    [Free]
    public delegate bit FixedTernaryPred<F>(F a, F b, F c);

    [Free]
    public delegate void FixedAction<X0>(X0 x0);

    [Free]
    public delegate void FixedAction<X0,X1>(X0 x0, X1 x1);

    [Free]
    public delegate void FixedAction<X0,X1,X2>(X0 x0, X1 x1, X2 x2);
}