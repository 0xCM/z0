//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes an operator that emits a potentially modified receipt value
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate ref T EditorOp<T>(ref T src);

    /// <summary>
    /// Characterizes an operator that emits a value identical to that which was received
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly T RelayOp<T>(in T src);
    
    /// <summary>
    /// Characterizes a function that produces T-values from S-values
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Mapper<S,T>(in S src);
}