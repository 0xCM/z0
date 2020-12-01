//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a service that exposes a source
    /// </summary>
    [Free]
    public interface ISourceProvider
    {
        /// <summary>
        /// The provided source
        /// </summary>
        ISource Source {get;}
    }

    /// <summary>
    /// Characterizes a source-parametric <see cref='ISourceProvider'/>
    /// </summary>
    /// <typeparam name="T">The source type</typeparam>
    [Free]
    public interface ISourceProvider<T> : ISourceProvider
        where T : ISource
    {
        new T Source {get;}

        ISource ISourceProvider.Source
            => Source;
    }
}