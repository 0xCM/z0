//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines a root interface for types that reify operations that accept an
    /// input but yield no output
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IReceiver : ISink
    {
        
    }

    /// <summary>
    /// Characterizes a structural operation that reifies a receiver, referred 
    /// to as a structural receiver or sink
    /// </summary>
    /// <typeparam name="T">The input type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IReceiver<T> : IReceiver, ISink<T>
    {
        Receiver<T> Operation
        {                    
            [MethodImpl(Inline)]
            get => Accept;
        }
    }

    /// <summary>
    /// Characterizes a structural receiver that accepts a stream
    /// </summary>
    /// <typeparam name="T">The stream element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IStreamReceiver<T> : IReceiver<IEnumerable<T>>
    {
        
    }

    /// <summary>
    /// Characterizes a structural receiver that accepts a span
    /// </summary>
    /// <typeparam name="T">The apn element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanReceiver<T> : IReceiver
    {
        void Accept(Span<T> src);

        SpanReceiver<T> Operation
        {                    
            [MethodImpl(Inline)]
            get => Accept;
        }
    }
}