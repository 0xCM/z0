//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct Try
    {
        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None together with the reported exceptions
        /// </summary>
        /// <param name="f">The function to evaluate</param>
        /// <typeparam name="T">The function result type, if successful</typeparam>
        public static Option<T> @try<T>(Func<T> f, Action<Exception> error = null)
        {
            try
            {
                return f();
            }
            catch (Exception e)
            {
                if(error != null)
                    error(e);
                else
                    errout(e);

                return none<T>();
            }
        }

        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None together with the reported exception
        /// </summary>
        /// <param name="f">The function to evaluate</param>
        /// <typeparam name="T">The function result type, if successful</typeparam>
        [MethodImpl(Inline)]   
        public static Option<T> @try<T>(Func<Option<T>> f, Action<Exception> error = null)
        {
            try
            {
                return f();
            }
            catch (Exception e)
            {
                if(error != null)
                    error(e);
                else
                    errout(e);
                return none<T>();
            }
        }

        /// <summary>
        /// Invokes an action within a try block and, upon error, calls
        /// the handler if specified. If no handler is specified, the exception
        /// message is emitted to stderr
        /// </summary>
        /// <param name="f">The action to invoke</param>
        /// <param name="onerror">The error handler to call, if specified</param>
        public static void @try(Action f, Action<Exception> error = null)
        {
            try
            {
                f();
            }
            catch(Exception e)
            {
                if(error != null)
                    error(e);
                else
                    errout(e);
            }
        }

        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None together with the reported exception
        /// </summary>
        /// <typeparam name="X">The input type</typeparam>
        /// <typeparam name="Y">The output type</typeparam>
        /// <param name="x">The input value</param>
        /// <param name="f">The function to evaluate</param>
        [MethodImpl(Inline)]   
        public static Option<Y> @try<X, Y>(X x, Func<X, Y> f, Action<Exception> error = null)
        {
            try
            {
                return f(x);
            }
            catch (Exception e)
            {
                if(error != null)
                    error(e);
                else
                    errout(e);
                return none<Y>();
            }
        }
    }
}