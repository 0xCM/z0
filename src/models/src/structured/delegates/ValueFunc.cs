//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Security;

    /// <summary>
    /// Characterizes a function that projects one structural type onto another
    /// </summary>
    /// <param name="src">The source value</param>
    [SuppressUnmanagedCodeSecurity]
    public delegate ValueType ValueFunc(ValueType src);

    /// <summary>
    /// Characterizes a result-parametric value projector
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate ref T ValueFunc<T>(in ValueType src)
        where T : struct;

    /// <summary>
    /// Characterizes a fully-parameteric value projector
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate ref T ValueFunc<S,T>(in S src)
        where S : struct
        where T : struct;

}