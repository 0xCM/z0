//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Constructs a non-valued option
    /// </summary>
    /// <typeparam name="A">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static Option<A> none<A>() 
        => Option.none<A>();
    
    /// <summary>
    /// Constructs a valued option
    /// </summary>
    /// <param name="value">The option value</param>
    /// <typeparam name="A">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static Option<A> some<A>(A value) 
        => Option<A>.Some(value);
        
    /// <summary>
    /// Casts a value if possible, otherwise returns failure
    /// </summary>
    /// <typeparam name="T">The target type</typeparam>
    /// <param name="item">The object to cast</param>
    [MethodImpl(Inline)]   
    public static Option<T> tryCast<T>(object item)
        => item is T ? some((T)item) : none<T>();

    /// <summary>
    /// Evaluates a function within a try block and returns the value of the computation if 
    /// successful; otherwise, returns None together with the reported exceptions
    /// </summary>
    /// <typeparam name="T">The result type</typeparam>
    /// <param name="f">The function to evaluate</param>
    public static Option<T> Try<T>(Func<T> f, Action<Exception> error = null)
        => Z0.Try.@try(f,error);

    /// <summary>
    /// Evaluates a function within a try block and returns the value of the computation if 
    /// successful; otherwise, returns None together with the reported exception
    /// </summary>
    /// <param name="f"></param>
    /// <typeparam name="T"></typeparam>
    [MethodImpl(Inline)]   
    public static Option<T> Try<T>(Func<Option<T>> f, Action<Exception> error = null)
        => Z0.Try.@try(f,error);

    /// <summary>
    /// Invokes an action within a try block and, upon error, calls
    /// the handler if specified. If no handler is specified, the exception
    /// message is emitted to stderr
    /// </summary>
    /// <param name="f">The action to invoke</param>
    /// <param name="onerror">The error handler to call, if specified</param>
    public static void Try(Action f, Action<Exception> error = null)
        => Z0.Try.@try(f,error);

    /// <summary>
    /// Evaluates a function within a try block and returns the value of the computation if 
    /// successful; otherwise, returns None together with the reported exception
    /// </summary>
    /// <typeparam name="X">The input type</typeparam>
    /// <typeparam name="Y">The output type</typeparam>
    /// <param name="x">The input value</param>
    /// <param name="f">The function to evaluate</param>
    [MethodImpl(Inline)]   
    public static Option<Y> Try<X, Y>(X x, Func<X, Y> f, Action<Exception> error = null)
        => Z0.Try.@try(x,f,error);
}