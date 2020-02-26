//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;
    
    partial class xfunc
    {       
        /// <summary>
        /// Adds items to a list
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="list">The list to modify</param>
        /// <param name="items">The items to add</param>
        public static void AppendRange<T>(this IList<T> list, IEnumerable<T> items)
            => items.Iterate(item => list.Add(item));

        /// <summary>
        /// Constructs an integrally-indexed stream from a source stream
        /// </summary>
        /// <param name="index">The 0-based element index</param>
        /// <param name="value">The indexed value</param>
        /// <typeparam name="T">The value type</typeparam>
        public static IEnumerable<(int index, T value)> Index<T>(this IEnumerable<T> src)
        {
            var i = 0;
            var it = src.GetEnumerator();            
            while(it.MoveNext())
                yield return (i++, it.Current);
        }
            
        /// <summary>
        /// Transforms an array via an indexed mapping function
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static T[] Mapi<S, T>(this S[] src, Func<int,S, T> f)
        {
            var dst = new T[src.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = f(i,src[i]);
            return dst;
        }

        /// <summary>
        /// Transforms an array via an indexed mapping function with optional parallellism
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f">The mapping function</param>
        /// <param name="pll">Specifies whether the map the source values in parallell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static T[] Mapi<S, T>(this S[] src, Func<int,S, T> f, bool pll)
        {
            if(!pll)
                return src.Mapi(f);
            
            var dst = new T[src.Length];
            var pllQuery = from index in range(src.Length).AsParallel()
                            select (index, value: f(index, src[index]));
            var results = pllQuery.ToArray();
            foreach(var result in results)
                dst[result.index] = result.value;
            return dst;
        }

        /// <summary>
        /// Creates a read-only list from a source sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> src)
            => src.ToList();

        /// <summary>
        /// Creates a multiset from a source sequence
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The data type</typeparam>
        public static Multiset<T> ToMultiSet<T>(this IEnumerable<T> src)
            => new Multiset<T>(src);

        /// <summary>
        /// Returns the first element if it exists; otherwise returns the supplied default
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The items to search</param>
        /// <param name="default">The replacement value if the sequence is empty</param>
        public static T FirstOrDefault<T>(this IEnumerable<T> src, T @default)
            => src.Any() ? src.First() : @default;

        /// <summary>
        /// Returns the first element if it exists; otherwise returns the value supplied
        /// by invoking the default function
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The items to search</param>
        /// <param name="default">The function invoked to produce a default value</param>
        public static T FirstOrDefault<T>(this IEnumerable<T> src, Func<T> @default)
            => src.Any() ? src.First() : @default();

        /// <summary>
        /// Returns the last element if it exists; otherwise returns the supplied default
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="default">The replacement value if the sequence is empty</param>
        public static T LastOrDefault<T>(this IEnumerable<T> src, T @default = default)
            => src.Any() ? src.Last() : @default;

        /// <summary>
        /// Returns the last element if it exists; otherwise returns the value supplied
        /// by invoking the default function
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="default">The function invoked to produce a default value</param>
        public static T LastOrDefault<T>(this IEnumerable<T> src, Func<T> @default)
            => src.Any() ? src.Last() : @default();

        /// <summary>
        /// Applies a function to the first item in the list that satisfies the predicate if such an item exists.
        /// If no such item exists, the function is applied to the default value of the item
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <typeparam name="R">The function result type</typeparam>
        /// <param name="items">The items to search</param>
        /// <param name="predicate">The predicate applied during the search</param>
        /// <param name="f">The function to apply to the identified item</param>
        [MethodImpl(Inline)]
        public static R OnFirstOrDefault<T, R>(this IEnumerable<T> items, Predicate<T> predicate, Func<T, R> f) 
            => f(items.FirstOrDefault(x => predicate(x)));

        /// <summary>
        /// Returns the second term of the sequence if it exists; otherwise raises an exception
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The source stream</param>
        public static T Second<T>(this IEnumerable<T> src)
            => src.Skip(1).Take(1).Single();

        /// <summary>
        /// Returns the third term of the sequence if it exists; otherwise raises an exception
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The source stream</param>
        public static T Third<T>(this IEnumerable<T> src)
            => src.Skip(2).Take(1).Single();

        /// <summary>
        /// Returns the second term of the sequence if it exists; otherwise returns the default value
        /// </summary>
        /// <typeparam name="T">The sequence item type</typeparam>
        /// <param name="src">The source stream</param>
        public static T SecondOrDefault<T>(this IEnumerable<T> src)
            => src.Take(2).LastOrDefault();

        /// <summary>
        /// Determines whether two streams are identical
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="lhs">The first sequence</param>
        /// <param name="rhs">The second sequence</param>
        public static bool Eq<T>(this IEnumerable<T> lhs, IEnumerable<T> rhs)
            => lhs.SequenceEqual(rhs);

        /// <summary>
        /// Forces enumerable evaluation
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static T[] Force<T>(this IEnumerable<T> src)
            => src.ToArray();

        /// <summary>
        /// Constructs a sequence of singleton sequences from a sequence of elements
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        public static IEnumerable<IEnumerable<T>> Singletons<T>(this IEnumerable<T> src)
            => singletons(src);

        /// <summary>
        /// Reduces a stream of element streams to an element stream
        /// </summary>
        /// <param name="src">The element streams</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> Collapse<T>(this IEnumerable<IEnumerable<T>> src)
            => src.SelectMany(y => y);

        /// <summary>
        /// Prepends one or more items to the head of the sequence
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The sequence that will be prependend</param>
        /// <param name="preceding">The items that will be prepended</param>
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> src, params T[] preceding)
            => preceding.Concat(src);

        /// <summary>
        /// Applies the effect to each item in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="f">The side-effect</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void Effect<T>(this IEnumerable<T> src, Action<T> f)
        {
            foreach(var item in src)
                f(item);
        }

        /// <summary>
        /// Enumerates stream elements in pairs, until one of the streams is exhausted,
        /// invoking a traversal action for each enumerated pair
        /// </summary>
        /// <param name="lhs">The left stream</param>
        /// <param name="rhs">The right stream</param>
        /// <param name="f">The side-effect</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void Effect<T>(this IEnumerable<T> lhs, IEnumerable<T> rhs, Action<T,T> f)
        {
            var left = lhs.GetEnumerator();
            var right = rhs.GetEnumerator();

            while(left.MoveNext() && right.MoveNext())
                f(left.Current, right.Current);            
        }

        public static (IEnumerable<T> left, IEnumerable<T> right) Fork<T>(this IEnumerable<T> src)
            => (src, src);
        
        public static IEnumerable<T> Transform<S,T>(this IEnumerable<S> src, params Func<S,T>[] transformers)
            => src.Select(item => transformers.Select(t => t(item))).SelectMany(x => x);
    }
}