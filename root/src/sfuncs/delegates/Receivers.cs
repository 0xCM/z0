//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Characterizes a function that accepts an input of parametric type
    /// </summary>
    /// <typeparam name="T">The input type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate void Receiver<T>(in T src);

    /// <summary>
    /// Characterizes a receiver that accepts a stream
    /// </summary>
    /// <typeparam name="T">The stream element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate void StreamReceiver<T>(IEnumerable<T> src);
}