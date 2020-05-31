//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Seed;

    [SuppressUnmanagedCodeSecurity]
    public delegate void DataReceiver<T>(T data);

}