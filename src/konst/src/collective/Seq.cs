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

    using static Konst;

    [ApiHost]
    public readonly struct Seq
    {
        /// <summary>
        /// Constructs a nonempty stream
        /// </summary>
        /// <param name="head">The first element in the stream</param>
        /// <param name="tail">The remaining elements of the stream</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        [Op, Closures(UInt64k)]
        public static Source<T> nonempty<T>(T head, params T[] tail)
            => z.seq(nes(head,tail));

        [Op, Closures(UInt64k)]
        static IEnumerable<T> nes<T>(T head, params T[] tail)
        {
            yield return head;

            foreach (var t in tail)
                yield return t;
        }

        /// <summary>
        /// Constructs a stream, possibly empty
        /// </summary>
        /// <param name="src">The stream elements</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static Source<T> from<T>(params T[] src)
            => src;

        /// <summary>
        /// Concatenates the source streams to create a unified stream
        /// </summary>
        /// <param name="head">The first part of the sequence</param>
        /// <param name="tail">The last part of the sequence</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static Source<T> from<T>(Source<T> head, Source<T> tail)
            => head.Concat(tail);

        /// <summary>
        /// Concatenates the source streams to create a unified stream
        /// </summary>
        /// <param name="s1">The leading segment</param>
        /// <param name="s2">The second segment</param>
        /// <param name="s3">The terminal segment</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static Source<T> from<T>(Source<T> s1, Source<T> s2, Source<T> s3)
            => s1.Concat(s2).Concat(s3);

        /// <summary>
        /// All of your streams belong to us
        /// </summary>
        /// <param name="src">The source streams</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static Source<T> join<T>(params IEnumerable<T>[] src)
            => src.SelectMany(x => x);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static Source<T> from<T>(IEnumerable<T> src)
            => new Source<T>(src);


        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static Source<T> empty<T>()
            => Source<T>.Empty;
    }
}