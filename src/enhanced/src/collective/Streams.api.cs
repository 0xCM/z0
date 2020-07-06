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

    using static Konst;

    public static class Streams
    {    
        /// <summary>
        /// Constructs a nonempty stream
        /// </summary>
        /// <param name="head">The first element in the stream</param>
        /// <param name="tail">The remaining elements of the stream</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        public static IEnumerable<T> nonempty<T>(T head, params T[] tail)
        {
            yield return head;

            foreach (var t in tail)
                yield return t;
        }

        /// <summary>
        /// Constructs a stream, possily empty
        /// </summary>
        /// <param name="src">The stream elements</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        public static IEnumerable<T> from<T>(params T[] src)
            => src;

        /// <summary>
        /// Concatenates the source streams to create a unified stream
        /// </summary>
        /// <param name="head">The first part of the sequence</param>
        /// <param name="tail">The last part of the sequence</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        public static IEnumerable<T> from<T>(IEnumerable<T> head, IEnumerable<T> tail)
            => head.Concat(tail);

        /// <summary>
        /// Concatenates the source streams to create a unified stream
        /// </summary>
        /// <param name="s1">The leading segment</param>
        /// <param name="s2">The second segment</param>
        /// <param name="s3">The terminal segment</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        public static IEnumerable<T> from<T>(IEnumerable<T> s1, IEnumerable<T> s2, IEnumerable<T> s3)
            => s1.Concat(s2).Concat(s3);

        /// <summary>
        /// All of your streams belong to us
        /// </summary>
        /// <param name="src">The source streams</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        public static IEnumerable<T> join<T>(params IEnumerable<T>[] src)
            => src.SelectMany(x => x);

    }
}