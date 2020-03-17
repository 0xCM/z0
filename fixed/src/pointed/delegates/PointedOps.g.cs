//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using static Root;

    [SuppressUnmanagedCodeSecurity]
    public delegate Point<R> PointedFunc<R>()
        where R : unmanaged, IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate Point<R> PointedFunc<X0,R>(in Point<X0> x0)
        where X0 : unmanaged, IFixed
        where R : unmanaged, IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate Point<R> PointedFunc<X0,X1,R>(in MixedPoint<X0,X1> x0)
        where X0 : unmanaged, IFixed
        where X1 : unmanaged, IFixed
        where R : unmanaged, IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate Point<R> PointedFunc<X0,X1,X2,R>(in MixedPoint<X0,X1,X2> x0)
        where X0 : unmanaged, IFixed
        where X1 : unmanaged, IFixed
        where X2 : unmanaged, IFixed
        where R : unmanaged, IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate R PointEvaluator<R>()
        where R : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Y PointEvaluator<X,Y>(in X x)
        where X : unmanaged
        where Y : unmanaged;
}