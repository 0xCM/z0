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

    using static Root;

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
    }
}