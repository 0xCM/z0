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
    /// Defines the canonical shape of an emitter
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Emitter<T>();

    /// <summary>
    /// Characterizes a function that produces a stream of values
    /// </summary>
    /// <param name="count">If specified, the number of elements to produce</param>
    /// <typeparam name="T">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate IEnumerable<T> StreamEmitter<T>(int? count = null);

    /// <summary>
    /// Root interface for value production services
    /// </summary>
    public interface ISource
    {
        
    }

    /// <summary>
    /// Characterizes an unlimited emitter that produces one element at a time
    /// </summary>
    /// <typeparam name="T">The production element type</typeparam>
    public interface ISource<T> : ISource
    {
        /// <summary>
        /// Retrieves the next item from the source
        /// </summary>
        T Next();                   
    }

    public interface IPointStream<T>  : ISource<T>, IEnumerable<T>
    {
        /// <summary>
        /// Retrieves the next sequence of values, with optionally-governed count
        /// </summary>
        /// <param name="count">The number of elements</param>
        IEnumerable<T> Next(int? count = null);

    }

    public interface IStreamSource<T> : ISource<T>
    {
        IEnumerable<T> Stream {get;}        
    }
}