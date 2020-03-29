//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Security;

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

    [SuppressUnmanagedCodeSecurity]
    public interface IStreamSource<T> : ISource<IEnumerable<T>>
    {
     
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ICallbackSouce<T> : ISource
    {

        event Action<T> Next;
    }

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

    /// <summary>
    /// Characterizes an unlimited value emitter that produces one value at a time
    /// </summary>
    /// <typeparam name="T">The production value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IValueSource<T> : ISource<T>
        where T : struct
    {

    }    

    /// <summary>
    /// Characterizes a value emitter that supports placcing upper and/or lower bounds on
    /// the values produced
    /// </summary>
    /// <typeparam name="T">The production value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBoundValueSource<T> : IValueSource<T>
        where T : struct
    {
        /// <summary>
        /// Retrieves the next point from the source, constrained by an upper bound
        /// </summary>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next(T max);    
        
        /// <summary>
        /// Retrieves the next point from the source, constrained by upper and lower bounds
        /// </summary>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive max value</param>
        T Next(T min, T max);        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IValueStream<T> : IEnumerable<T>, IValueSource<T>
        where T : struct
    {
    
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IValueStreamSource<T> : IValueSource<T>
        where T : struct
    {        
        ValueStreamEmitter<T> Emitter {get;}        
    }    
}