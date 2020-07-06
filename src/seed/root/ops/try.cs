//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class RootLegacy
    {        
        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None and invokes an error handler if supplied
        /// </summary>
        /// <typeparam name="T">The result type</typeparam>
        /// <param name="f">The function to evaluate</param>
        [MethodImpl(Inline)]   
        public static Option<T> Try<T>(Func<T> f, Action<Exception> handler = null)
            => Option.Try(f,handler);

        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None together with the reported exception
        /// </summary>
        /// <param name="f">The function to evaluate</param>
        /// <typeparam name="T">The function result type, if successful</typeparam>
        [MethodImpl(Inline)]   
        public static Option<T> Try<T>(Func<Option<T>> f, Action<Exception> handler = null)
            => Option.Try(f,handler);            

        /// <summary>
        /// Invokes an action within a try block and, upon error, calls the handler if specified. 
        /// If no handler is specified, the exception message is emitted to stderr
        /// </summary>
        /// <param name="f">The action to invoke</param>
        /// <param name="onerror">The error handler to call, if specified</param>
        [MethodImpl(Inline)]   
        public static void Try(Action f, Action<Exception> handler = null)
            => Option.Try(f,handler);

        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if successful.
        /// Otherwise, returns None together with the reported exception
        /// </summary>
        /// <typeparam name="X">The input type</typeparam>
        /// <typeparam name="Y">The output type</typeparam>
        /// <param name="x">The input value</param>
        /// <param name="f">The function to evaluate</param>
        [MethodImpl(Inline)]   
        public static Option<Y> Try<X,Y>(X x, Func<X,Y> f, Action<X,Exception> handler = null)
            => Option.Try(x,f,handler);

        /// <summary>
        /// Casts a value if possible, otherwise returns none
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="item">The object to cast</param>
        [MethodImpl(Inline)]   
        public static Option<T> TryCast<T>(object item)
            => item is T ? Option.some((T)item) : Option.none<T>();
    }
}