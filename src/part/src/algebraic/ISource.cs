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
    /// Root interface for value production services
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface ISource
    {

    }

    /// <summary>
    /// Characterizes an unlimited emitter that produces one element at a time
    /// </summary>
    /// <typeparam name="T">The production element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISource<T> : ISource
    {
        /// <summary>
        /// Retrieves the next item from the source
        /// </summary>
        T Next();
    }
}