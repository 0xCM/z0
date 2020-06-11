//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static PartIdentity;
    
    partial class XTend
    {
        /// <summary>
        /// Defines an array-specific select operator
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The mapping function</param>
        [MethodImpl(Inline)]
        public static T[] Select<S,T>(this S[] src, Func<S,T> f)
            => map(src,f);   

        [MethodImpl(Inline)]
        public static T[] Skip<T>(this T[] src, int count)
            => Enumerable.Skip(src, count).ToArray();

        /// <summary>
        /// Linq where operator specialized for arrays
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f"></param>
        /// <typeparam name="T">The array element type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Where<T>(this T[] src, Func<T,bool> f)
            => filter(src,f);

        /// <summary>
        /// Linq orderby operator specialized for arrays
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f">The order criterion selector</param>
        /// <typeparam name="T">The array element type</typeparam>
        /// <typeparam name="K">The order criterion type</typeparam>
        [MethodImpl(Inline)]
        public static T[] OrderBy<T,K>(this T[] src, Func<T,K> f)
            => Enumerable.OrderBy(src,f).ToArray();

        /// <summary>
        /// Result = Filter + Project
        /// </summary>
        /// <param name="src"></param>
        /// <param name="test"></param>
        /// <param name="project"></param>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        public static T[] Where<S,T>(this S[] src, Func<S,bool> test, Func<S,T> project)
            => map(filter(src,test), project);

        /// <summary>
        /// Populates a target array by casting each elements of a source aray to the target element type
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static T[] Cast<T>(this object[] src)
            => cast<T>(src);

        [MethodImpl(Inline)]
        static T cast<T>(object src)
            => (T)src;

        [MethodImpl(Inline)]
        static T[] cast<T>(object[] src)
        {
            var dst = new T[src.Length];
            for(var i=0; i<src.Length; i++)
                dst[i] = cast<T>(src[i]);
            return dst;
        }

        /// <summary>
        /// Allocates and populates a new array by filtering the source array with 
        /// a specified predicate
        /// </summary>
        /// <param name="src">The soruce array</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The array element type</typeparam>
        static T[] filter<T>(T[] src, Func<T,bool> f)
        {
            Span<T> dst = new T[src.Length];
            var count = 0;
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var test = ref src[i];
                if(f(test))
                    dst[count++] = test;                    
            }   
            return dst.Slice(0, count).ToArray();
        }

        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        static T[] map<S,T>(IEnumerable<S> src, Func<S,T> f)
            => src.Select(item => f(item)).ToArray();
    }
}