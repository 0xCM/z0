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

    public static partial class OptionX
    {
        /// <summary>
        /// Applies a map to a valued option; otherwise, raises an exception
        /// </summary>
        /// <param name="x">The optional value</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="X">The source type</typeparam>
        /// <typeparam name="Y">The target type</typeparam>
        public static Y MapRequired<X, Y>(this Option<X> x, Func<X, Y> f)
            => f(x.Require());

        /// <summary>
        /// Removes an element from the queue if one exists
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="q">the queue</param>
        public static Option<T> TryPop<T>(this Queue<T> q)
            => q.IsEmpty() ? none<T>() : some(q.Dequeue()); 

        [MethodImpl(Inline)]
        public static IEnumerable<Option<T>> Condense<T>(this IEnumerable<IEnumerable<Option<T>>> options)
            => options.SelectMany(x => x);

        /// <summary>
        /// Extracts the encapsluated value if present; otherwise returns the default value of the type
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="x">The optional value</param>
        [MethodImpl(Inline)]
        public static T Value<T>(this Option<T> x)
            where T : struct => x.ValueOrDefault();

        [MethodImpl(Inline)]
        public static IReadOnlyList<P> Items<P>(this Option<P[]> x)
            => x.ValueOrElse(() => new P[]{});

        [MethodImpl(Inline)]
        public static IEnumerable<T> Items<T>(this Option<IEnumerable<T>> x, Action error = null)
        {

            if (x)
                return x.ValueOrDefault();
            else
            {
                error?.Invoke();
                return new T[] { };
            }
        }

        [MethodImpl(Inline)]
        public static P First<P>(this Option<P[]> x)
            => x.Items().First();

        [MethodImpl(Inline)]
        public static P FirstOrDefault<P>(this Option<P[]> x)
            => x.Items().FirstOrDefault();

        /// <summary>
        /// Extracts the encapsulated values from a sequence of optional values (where Some)
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="options">The options to examine</param>
        [MethodImpl(Inline)]
        public static IEnumerable<T> Values<T>(this IEnumerable<Option<T>> options)
            => options.WhereSome().Select(x => x.ValueOrDefault());

        [MethodImpl(Inline)]
        public static T SingleOrDefault<T>(this Option<IEnumerable<T>> x)
            => x.MapValueOrDefault(seq => seq.SingleOrDefault());

        [MethodImpl(Inline)]
        public static T First<T>(this Option<IEnumerable<T>> x)
            => x.MapRequired(y => y.First());

        [MethodImpl(Inline)]
        public static T FirstOrDefault<T>(this Option<IEnumerable<T>> x)
            => x.MapValueOrDefault(seq => seq.FirstOrDefault());

        [MethodImpl(Inline)]
        public static T Single<T>(this Option<T> x)
            where T : IEnumerable<T>
                => x.MapRequired(z => z.Single());

        [MethodImpl(Inline)]
        public static Option<T> TryGetFirst<T>(this IEnumerable<Option<T>> potentials)
        {
            var o = potentials.Where(x => x.IsSome()).ToList();
            return o.Any() ? o.First() : Option.none<T>();
        }

        /// <summary>
        /// Returns a value if the source stream yeilds exactly one value; otherwise, returns none
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The stream element type</typeparam>
        [MethodImpl(Inline)]
        public static Option<T> TryGetSingle<T>(this IEnumerable<T> src)
            => src.Count() == 1 ? src.Single() : Option.none<T>();


        /// <summary>
        /// Returns a value if the source stream yeilds exactly one value that satisfied a predicate; otherwise, returns none
        /// </summary>
        /// <param name="stream">The stream to search</param>
        /// <param name="predicate">The predicate to match</param>
        /// <typeparam name="T">The stream item type</typeparam>
        [MethodImpl(Inline)]
        public static Option<T> TryGetSingle<T>(this IEnumerable<T> stream, Func<T, bool> predicate)
        {
            var satisfied = stream.Where(predicate).ToList();
            if (satisfied.Count != 1)
                return Option.none<T>();
            else
                return satisfied[0];
        }

        /// <summary>
        /// Searches for the first element in the stream that satisfies a predicate and returns the
        /// element if found; otherwise, returns None
        /// </summary>
        /// <typeparam name="X">The stream item type</typeparam>
        /// <param name="stream">The stream to search</param>
        /// <param name="predicate">The predicate to match</param>
        [MethodImpl(Inline)]
        public static Option<X> TryGetFirst<X>(this IEnumerable<X> stream, Func<X, bool> predicate)
            => stream.FirstOrDefault(predicate);

        /// <summary>
        /// Selects the subsequence for which values exist, if any
        /// </summary>
        /// <typeparam name="T">The potential value type</typeparam>
        /// <param name="options">The sequence of options to examine</param>
        [MethodImpl(Inline)]
        public static IEnumerable<Option<T>> WhereNone<T>(this IEnumerable<Option<T>> options)
            => from option in options where option.IsNone() select option;

        /// <summary>
        /// Selects the subsequence for which values exist, if any
        /// </summary>
        /// <typeparam name="T">The potential value type</typeparam>
        /// <param name="options">The sequence of options to examine</param>
        [MethodImpl(Inline)]
        public static IEnumerable<Option<T>> WhereSome<T>(this IEnumerable<Option<T>> options)
            => from option in options where option.IsSome() select option;

        /// <summary>
        /// Returns true if an optioal value exists an a specified predicate over the value is satisfied
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="x">The value to examine</param>
        /// <param name="predicate">The adjudicating predicate</param>
        [MethodImpl(Inline)]
        public static bool Satisfies<T>(this Option<T> x, Predicate<T> predicate)
            => x.TryMap(y => predicate(y)).ValueOrDefault();

        /// <summary>
        /// Bifurcates a stream of optional values into the haves/have nots
        /// </summary>
        /// <typeparam name="T">The optional value type</typeparam>
        /// <param name="options">The stream of options to evaluate</param>
        public static (IEnumerable<Option<T>> Left, IEnumerable<T> Right) Split<T>(this IEnumerable<Option<T>> options)
            => (options.WhereNone(), options.WhereSome().Select(x => x.ValueOrDefault()));

        /// <summary>
        /// Evaluates to true iff all options have values
        /// </summary>
        /// <param name="options">The options to evaluate</param>
        [MethodImpl(Inline)]
        public static bool All(params IOption[] options)
            => options.All(o => o.IsSome);

        /// <summary>
        /// Invokes an action when all supplied options have value
        /// </summary>
        /// <typeparam name="X1">The type of the first potential item</typeparam>
        /// <typeparam name="X2">The type of the second potential item</typeparam>
        /// <param name="x1">The first potential value</param>
        /// <param name="x2">The second potential value</param>
        /// <param name="f">The action to conditionally invoke</param>
        [MethodImpl(Inline)]
        public static void WhenAll<X1, X2>(Option<X1> x1, Option<X2> x2, Action<X1, X2> f)
            => Root.onTrue(All(x1,x2), () => f(x1.Require(), x2.Require()));

        /// <summary>
        /// Invokes the supplied action if all values exist
        /// </summary>
        /// <typeparam name="X1">The type of the first potential value</typeparam>
        /// <typeparam name="X2">The type of the second potential value</typeparam>
        /// <typeparam name="X3">The type of the third potential value</typeparam>
        /// <param name="x1">The first potential value</param>
        /// <param name="x2">The second potential value</param>
        /// <param name="x3">The third potential value</param>
        /// <param name="f">The action to conditionally invoke</param>
        [MethodImpl(Inline)]
        public static void WhenAll<X1, X2, X3>(Option<X1> x1, Option<X2> x2, Option<X3> x3, Action<X1, X2, X3> f)
            => Root.onTrue(All(x1,x2,x3), () => f(x1.Require(), x2.Require(), x3.Require()));                    
    }
}