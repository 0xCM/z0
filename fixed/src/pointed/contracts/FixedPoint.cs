//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedPoint<X0> : IPointed<Point<X0>>
        where X0 : unmanaged,IFixed
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedPoint<X0,X1> : IPointed<MixedPoint<X0,X1>>
        where X0 : unmanaged,IFixed
        where X1 : unmanaged,IFixed
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedPoint<X0,X1,X2> : IPointed<MixedPoint<X0,X1,X2>>
        where X0 : unmanaged,IFixed
        where X1 : unmanaged,IFixed
        where X2 : unmanaged,IFixed
    {

    }
}