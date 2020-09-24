//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a value operator
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The operand/target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate ref T ValueOperator<T>(in T src)
        where T : struct;
}