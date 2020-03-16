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


}