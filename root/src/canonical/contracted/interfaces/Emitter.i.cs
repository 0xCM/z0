//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using static Root;

    /// <summary>
    /// Chracterizes an operation that produces a value that does not depend on arguments
    /// </summary>
    /// <typeparam name="A">The production type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IEmitter<A> : IFunc<A>
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISegmentedEmitter<T> : IEmitter<T>
        where T : unmanaged
    {
        NumericKind CellKind {get;}
    }

    /// <summary>
    /// Chracterizes an operation that produces a value that does not depend on arguments
    /// and where the production type T covers a whole number of C-segments
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    /// <typeparam name="C">The cell type over which the production type is segmented</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IEmitter<T,C> : ISegmentedEmitter<T>
        where T : unmanaged
        where C : unmanaged
    {
        NumericKind ISegmentedEmitter<T>.CellKind => typeof(T).NumericKind();            
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