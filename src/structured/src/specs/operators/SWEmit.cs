//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

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
}