//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;
    using static zfunc;

    /// <summary>
    /// Characterizes a parametric, pointwise transport
    /// </summary>
    /// <typeparam name="A">The point type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPointExchange<A>
    {
        
    }

    /// <summary>
    /// Characterizes a point exchange with predetermined capacity
    /// </summary>
    /// <typeparam name="A">The point type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ICountedExchange<A> : IPointExchange<A>
    {
        /// <summary>
        /// The number of points in the exchange
        /// </summary>
        int Count {get;}
    }

    /// <summary>
    /// Characterizes a point emitter
    /// </summary>
    /// <typeparam name="A">The type of point emitted</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IExchangeSource<A> : IPointExchange<A>
    {

    }

    /// <summary>
    /// Characterizes a point receiver
    /// </summary>
    /// <typeparam name="A">The type of point received</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IExchangeSink<A> : IPointExchange<A>
    {

    }

    /// <summary>
    /// Characterizes an emitter of index-identified points
    /// </summary>
    /// <typeparam name="A">The type of point emitted</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IIndexedSource<A> : IExchangeSource<A>, ICountedExchange<A>
    {
        /// <summary>
        /// Emits a point from an index-identified slot
        /// </summary>
        /// <param name="index">The point index</param>
        A Point(int index);        
    }

    /// <summary>
    /// Characterizes a receiver of index-identified points
    /// </summary>
    /// <typeparam name="A">The type of point received</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IIndexedSink<A> : IExchangeSink<A>, ICountedExchange<A>
    {
        /// <summary>
        /// Receives a point in an index-identified slot
        /// </summary>
        /// <param name="index">The point index</param>
        /// <param name="point">The point value</param>
        void Point(int index, A point);        
    }

    /// <summary>
    /// Characterizes an exchange that emits/receives index-identified points
    /// </summary>
    /// <typeparam name="A">The type of point exchanged</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IIndexedExchange<A> : IIndexedSource<A>, IIndexedSink<A>
    {
        /// <summary>
        /// Queries/manipulates a point in an index-identified slot
        /// </summary>
        A this[int index]
        {
            [MethodImpl(Inline)]            
            get => Point(index);

            [MethodImpl(Inline)]            
            set => Point(index, value);
        }
    }

}