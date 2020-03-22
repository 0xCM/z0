//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the canonical shape of an emitter
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Emitter<T>();

    /// <summary>
    /// Defines the canonical shape of an emitter
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    /// <typeparam name="C">The cell type into which the production type is segmented</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Emitter<T,C>();

    /// <summary>
    /// Delegate synonym for an emitter
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T NullaryFunc<T>();

    /// <summary>
    /// Defines the canonical shape of a value emitter
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T ValueEmitter<T>()
        where T : struct;   

    /// <summary>
    /// Characterizes a value emitter that may run out of values to emit
    /// </summary>
    /// <typeparam name="T">The emission value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate Option<T> LimitedEmitter<T>();

    /// <summary>
    /// Characterizes a function that produces a stream of values
    /// </summary>
    /// <param name="count">If specified, the number of elements to produce</param>
    /// <typeparam name="T">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate IEnumerable<T> StreamEmitter<T>();

    /// <summary>
    /// Characterizes a function that produces a stream of values
    /// </summary>
    /// <param name="count">If specified, the number of elements to produce</param>
    /// <typeparam name="T">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate IEnumerable<T> ValueStreamEmitter<T>()
        where T : struct;    

    /// <summary>
    /// Characterizes a function that produces spans values
    /// </summary>
    /// <typeparam name="T">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate Span<T> SpanEmitter<T>();

    /// <summary>
    /// Chracterizes an operation that produces a value that does not depend on arguments
    /// </summary>
    /// <typeparam name="A">The production type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IEmitter<A> : IFunc<A>, ISource
    {
        
    }

    /// <summary>
    /// Chracterizes an emitter with a result type of known width
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    /// <typeparam name="C">The cell type over which the production type is segmented</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IEmitter<W,T> : IEmitter<T>
        where W : unmanaged, ITypeWidth<W>

    {
        
    }

    /// <summary>
    /// Chracterizes an emitter where the production type T covers a whole number of C-segments
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    /// <typeparam name="C">The cell type over which the production type is segmented</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISegmentedEmitter<T,C> : IEmitter<T>
        where T : unmanaged
        where C : unmanaged
    {
        NumericKind CellKind => typeof(T).NumericKind();            
    }

    /// <summary>
    /// Characterizes an emitter that shoots out spans
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanEmitter<T> : ISpanFunc
    {
        Span<T> Invoke();

        FunctionClass IFunc.Class => FunctionClass.Emitter;
    }
}