//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static zfunc;

    /// <summary>
    /// Characterizes a transformation
    /// </summary>
    /// <typeparam name="A">The source domain type</typeparam>
    /// <typeparam name="B">The target domain type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IMap<A,B> : IFunc<A,B>
    {

    }
}