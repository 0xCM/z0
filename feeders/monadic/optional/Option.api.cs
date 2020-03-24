//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Monadic;

    public static class Option
    {
        /// <summary>
        /// Defines a non-valued option
        /// </summary>
        /// <typeparam name="T">The value type, if the value existed</typeparam>
        public static Option<T> none<T>()
            => Option<T>.None();

        /// <summary>
        /// Defines a valued option
        /// </summary>
        /// <param name="value">The value</param>
        /// <typeparam name="T">The type of the extant value</typeparam>
        public static Option<T> some<T>(T value)
            => Option<T>.Some(value);

        /// <summary>
        /// Classifies the value as some or none and manufactures the appropriate option encapsulation
        /// </summary>
        /// <typeparam name="T">The type of value</typeparam>
        /// <param name="value">The value to lift into option-space</param>
        public static Option<T> eval<T>(T value)
            where T : class
                => value is null ? none<T>()  : some(value);

        /// <summary>
        /// Classifies the value as some or none and manufactures the appropriate option encapsulation
        /// </summary>
        /// <typeparam name="T">The type of value</typeparam>
        /// <param name="value">The value to lift into option-space</param>
        public static Option<T> eval<T>(T? value)
            where T : struct
                => value.HasValue ? some(value.Value) : none<T>();

        /// <summary>
        /// Implements the canonical join operation that reduces the monadic depth by one level
        /// </summary>
        /// <param name="src">The optional option</param>
        /// <typeparam name="T">The encapsulated value</typeparam>
        public static Option<T> collapse<T>(Option<Option<T>> src)
            => src.ValueOrDefault(none<T>());

        /// <summary>
        /// Defines the canonical option functor F:Option[A] -> Option[B] induced by a non-monadic dual f:A->B
        /// </summary>
        /// <param name="f">A non-monadic projector</param>
        /// <typeparam name="A">The source type</typeparam>
        /// <typeparam name="B">The target type</typeparam>
        public static Func<Option<A>, Option<B>> fmap<A, B>(Func<A, B> f)
            => x => x.TryMap(a => f(a));

        /// <summary>
        /// Implements the canonical bind operation
        /// </summary>
        /// <typeparam name="X">The source domain type</typeparam>
        /// <typeparam name="Y">The target domain type</typeparam>
        /// <param name="x">The point in the monadic space over X</param>
        /// <param name="f">The function to apply to effect the bind</param>
        public static Option<Y> bind<X, Y>(Option<X> x, Func<X, Option<Y>> f)
            => x ? f(x.ValueOrDefault()) : none<Y>();        

        /// <summary>
        /// Evaluates a function if a predicate is satisfied; otherwise, returns None
        /// </summary>
        /// <typeparam name="X">The type of value to evaluate</typeparam>
        /// <typeparam name="Y">The evaluation type</typeparam>
        /// <param name="x">The point of evaluation</param>
        /// <param name="predicate">A precondition for evaulation to proceed</param>
        /// <param name="f">The evaluation function</param>
        [MethodImpl(Inline)]   
        public static Option<Y> guard<X, Y>(X x, Func<X, bool> predicate, Func<X, Option<Y>> f)
            => predicate(x) ? f(x) : none<Y>();

        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None and invokes an error handler if supplied
        /// </summary>
        /// <typeparam name="T">The result type</typeparam>
        /// <param name="f">The function to evaluate</param>
        public static Option<T> Try<T>(Func<T> f, Action<Exception> handler = null)
        {
            try
            {
                return f();
            }
            catch (Exception e)
            {
                Handle(e,handler);
                return none<T>();
            }
        }

        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None together with the reported exception
        /// </summary>
        /// <param name="f">The function to evaluate</param>
        /// <typeparam name="T">The function result type, if successful</typeparam>
        public static Option<T> Try<T>(Func<Option<T>> f, Action<Exception> handler = null)
        {
            try
            {
                return f();
            }
            catch (Exception e)
            {
                Handle(e,handler);
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
        public static void Try(Action f, Action<Exception> handler = null)
        {
            try
            {
                f();
            }
            catch(Exception e)
            {
                Handle(e,handler);
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
        public static Option<Y> Try<X, Y>(X x, Func<X, Y> f, Action<Exception> handler = null)
        {
            try
            {
                return f(x);
            }
            catch (Exception e)
            {
                Handle(e,handler);
                return none<Y>();
            }
        }

        static void Handle(Exception e, Action<Exception> handler)
        {
            if(handler != null) handler.Invoke(e); else Console.Error.WriteLine(e);
        }

    }
}