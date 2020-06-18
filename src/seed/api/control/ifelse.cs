//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        /// <summary>
        /// Evaluates a function over a value if the value is not null; otherwise, returns the default result value
        /// </summary>
        /// <typeparam name="X">The operand type</typeparam>
        /// <typeparam name="Y">The return type</typeparam>
        /// <param name="x">The operand</param>
        /// <param name="f1">The function to potentially evaluate</param>
        [MethodImpl(Inline)]
        public static Y ifNotNull<X,Y>(X x, Func<X,Y> f1, Y @default = default)
            => x != null ? f1(x) : @default;

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
    }
}