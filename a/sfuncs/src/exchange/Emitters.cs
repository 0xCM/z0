//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Chracterizes an operation that produces a value that does not depend on arguments
    /// </summary>
    /// <typeparam name="A">The production type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISEmitter<A> : ISFuncApi<A>, ISource
    {
        
    }

    /// <summary>
    /// Chracterizes an emitter with a result type of known width
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    /// <typeparam name="C">The cell type over which the production type is segmented</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IEmitter<W,T> : ISEmitter<T>
        where W : unmanaged, ITypeWidth<W>
    {
        
    }

    /// <summary>
    /// Chracterizes an emitter where the production type T covers a whole number of C-segments
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    /// <typeparam name="C">The cell type over which the production type is segmented</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISegmentedEmitter<T,C> : ISEmitter<T>
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
    public interface ISpanEmitter<T> : ISSpanApi
    {
        Span<T> Invoke();
    }
}