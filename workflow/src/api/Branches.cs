//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class Branches
    {
        /// <summary>
        /// Transforms an input, branching on nullity evaluation
        /// </summary>
        /// <param name="x">The input</param>
        /// <param name="null">The emitter to invoke if the input is null</param>
        /// <param name="else">The function to invoke if the input is not null</param>
        /// <typeparam name="X">The input type</typeparam>
        /// <typeparam name="Y">The output type</typeparam>
        [MethodImpl(Inline)]
        public static Y ifnone<X, Y>(X x, Func<Y> @null, Func<X,Y> @else)
            where X : class
                => isnull(x) ? @null() : @else(x);

        /// <summary>
        /// Transforms an input value, branching on nullity evaluation
        /// </summary>
        /// <param name="x">The input</param>
        /// <param name="null">The emitter to invoke if the input is null</param>
        /// <param name="else">The onptional function to invoke if the input is not null; if no
        /// function is provided, the default target type value will be returned</param>
        /// <typeparam name="X">The input type</typeparam>
        /// <typeparam name="Y">The output type</typeparam>
        [MethodImpl(Inline)]
        public static Y ifnone<X, Y>(X? x, Func<Y> @null, Func<X,Y> @else = null)
            where X : struct
            where Y : struct
                => isnull(x) ? @null() : @else?.Invoke(x.Value) ?? default(Y);

        /// <summary>
        /// Invokes an action if the supplied value is not null
        /// </summary>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="x">The potentially null value</param>
        /// <param name="f">The action to invoke if possible</param>
        [MethodImpl(Inline)]
        public static void ifsome<T>(T x, Action<T> f)
            where T : class
        {
            if(notnull(x))
                f(x);
        }

        /// <summary>
        /// Invokes an action if the supplied value is not null
        /// </summary>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="x">The potentially null value</param>
        /// <param name="f">The action to invoke if possible</param>
        [MethodImpl(Inline)]
        public static void ifsome<T>(T? x, Action<T> f)
            where T : struct
        {
            if(x.HasValue)
                f(x.Value);
        }

        /// <summary>
        /// Executes one of two functions depending on the evaulation criterion
        /// </summary>
        /// <param name="x">The value to supply to the predicate and one of the handlers</param>
        /// <param name="bool">The predicate to evalue to determine which function will map the value</param>
        /// <param name="true">The function to evaulate when the criterion is true</param>
        /// <param name="false">The function to evaulate when the criterion is false</param>
        /// <typeparam name="X">The function input type</typeparam>
        /// <typeparam name="Y">The function output type</typeparam>
        [MethodImpl(Inline)]
        public static Y ifelse<X,Y>(X x, Func<X,bool> @bool, Func<X,Y> @true, Func<X,Y> @false)
            where X : struct
                => @bool(x) ? @true(x) : @false(x);

        /// <summary>
        /// Executes a function if the criterion is true, otherwise returns the supplied value
        /// </summary>
        /// <typeparam name="T">The function input/output type</typeparam>
        /// <param name="criterion">The criterion on which to branch</param>
        /// <param name="x">The value to supply to the chosen function</param>
        /// <param name="onTrue">The function to evaulate when the criterion is true</param>
        [MethodImpl(Inline)]
        public static X iftrue<X>(X x, Func<X,bool> @bool, Func<X,X> onTrue)
            where X : struct
                => @bool(x) ? onTrue(x) : x;


        /// <summary>
        /// Executes one action if a condition is true and another should it be false
        /// </summary>
        /// <param name="condition">Specifies whether some condition is true</param>
        /// <param name="true">The action to invoke when condition is true</param>
        /// <param name="false">The action to invoke when condition is false</param>
        [MethodImpl(Inline)]
        public static void ifelse(bool condition, Action @true, Action @false)
        {
            if (condition)
                @true();
            else
                @false();
        }

        /// <summary>
        /// Applies f(v) if v is of type X otherwise applies unmatched(v)
        /// </summary>
        /// <typeparam name="X">The match type</typeparam>
        /// <typeparam name="Y">The evaluation type</typeparam>
        /// <param name="v">The candidate value</param>
        /// <param name="f">The function to apply if matched</param>
        /// <param name="u">The function to apply if unmatched</param>
        [MethodImpl(Inline)]
        public static void ontype<X, Y>(object v, Func<X, Y> f)
        {
            if(v is X x)
                f(x);
        }
    }

}