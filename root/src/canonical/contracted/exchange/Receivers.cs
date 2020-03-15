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
    using static Root;

    /// <summary>
    /// Characterizes a function that accepts a single input of any sort
    /// </summary>
    /// <typeparam name="T">The input type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate void Receiver<T>(in T src);

    /// <summary>
    /// Characterizes a function that accepts a value
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T ValueReceiver<T>(in T src)
        where T : unmanaged;   

    /// <summary>
    /// Characterizes a function that accepts a stream of values
    /// </summary>
    /// <typeparam name="T">The stream element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate void StreamReceiver<T>(IEnumerable<T> src);

    [SuppressUnmanagedCodeSecurity]
    public delegate void SpanReceiver<T>(Span<T> src);

    /// <summary>
    /// Characterizes a function that accepts a span
    /// </summary>
    /// <typeparam name="T">The span cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate void SpanValueReceiver<T>(Span<T> src)
        where T : unmanaged;

    /// <summary>
    /// Characterizes a function that accepts a readonly span
    /// </summary>
    /// <typeparam name="T">The span cell type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate void ReadOnlySpanValueReceiver<T>(ReadOnlySpan<T> src)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public interface IReceiver : ISink
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IReceiver<T> : IReceiver, ISink<T>
    {
        Receiver<T> Operation
        {                    
            [MethodImpl(Inline)]
            get => Accept;
        }
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IStreamReceiver<T> : IReceiver<IEnumerable<T>>
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISpanValueReceiver<T> : IReceiver
        where T : unmanaged
    {
        void Accept(Span<T> src);

        SpanValueReceiver<T> Operation
        {                    
            [MethodImpl(Inline)]
            get => Accept;
        }
    }
}