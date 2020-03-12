//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Security;
    using System.Linq;
    using System.Runtime.CompilerServices;

    [SuppressUnmanagedCodeSecurity]
    public delegate void SinkReceiver<T>(in T src);

    [SuppressUnmanagedCodeSecurity]
    public delegate void SinkReceiver<A,B>(in A a, in B b);

    [SuppressUnmanagedCodeSecurity]
    public delegate void SinkReceiver<A,B,C>(in A a, in B b, in C c);
}