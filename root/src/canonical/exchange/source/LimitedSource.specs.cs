//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Security;

    /// <summary>
    /// Characterizes a value emitter that may run out of values to emit
    /// </summary>
    /// <typeparam name="T">The emission value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate Option<T> LimitedEmitter<T>();

    /// <summary>
    /// Characterizes an emission service taht may run out of values to emit
    /// </summary>
    /// <typeparam name="T">The emission value type</typeparam>
    public interface ILimitedSource<T> : ISource
    {
        /// <summary>
        /// Emits the next source value, if any
        /// </summary>
        Option<T> Next();
    }
}