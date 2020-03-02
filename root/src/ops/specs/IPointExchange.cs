//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static Root;

    /// <summary>
    /// Characterizes parametric pointwise transport
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
    /// Characterizes a receiver of index-identified points
    /// </summary>
    /// <typeparam name="A">The type of point received</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IIndexedSink<A> : IExchangeSink<A>, ICountedExchange<A>
    {
        /// <summary>
        /// Receives a point in an index-identified slot
        /// </summary>
        /// <param name="index">The slot index</param>
        /// <param name="value">The slot value</param>
        void Slot(int index, A value);        
    }

    /// <summary>
    /// Characterizes an emitter of index-identified points
    /// </summary>
    /// <typeparam name="A">The type of point emitted</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IIndexedSource<A> : IExchangeSource<A>, ICountedExchange<A>
    {
        /// <summary>
        /// Emits a value from an index-identified slot
        /// </summary>
        /// <param name="index">The slot index</param>
        A Slot(int index);        
    }

    /// <summary>
    /// Chracterizes an integer-indexed sequence
    /// </summary>
    /// <typeparam name="A">The sequence term type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IIndexedSeq<A> : IIndexedSource<A>
    {


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
            get => Slot(index);

            [MethodImpl(Inline)]            
            set => Slot(index, value);
        }
    }
}