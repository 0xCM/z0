//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes an emission service taht may run out of values to emit
    /// </summary>
    /// <typeparam name="T">The emission value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ILimitedSource<T> : ISource
    {
        /// <summary>
        /// Emits the next source value, if any
        /// </summary>
        Option<T> Next();
    }
}