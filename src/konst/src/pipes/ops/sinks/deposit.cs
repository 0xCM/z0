//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    partial struct Sinks
    {
        [Op]
        public static void deposit(ReadOnlySpan<string> src, ISink<string> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                dst.Deposit(skip(src, i));
                dst.Deposit(Eol);
            }
        }

        [Op]
        public static void deposit(ReadOnlySpan<string> src, StreamWriter dst)
            => deposit(src, Sinks.create<string>(dst));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void deposit<T>(in T src, in Pipe<T> dst)
            => dst.Deposit(src);

        /// <summary>
        /// Fills a caller-supplied buffer with T-cell bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void deposit<T>(in T src, Span<byte> dst)
            where T : struct
                => @as<byte,T>(first(dst)) = src;

        /// <summary>
        /// Fills a caller-supplied span with data produced by a T-enumerable
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The element type</typeparam>
        [Op, Closures(Closure)]
        public static Span<T> deposit<T>(IEnumerable<T> src, Span<T> dst)
        {
            var i = 0u;
            var e = sys.enumerator(src);
            while(sys.next(e) && i < dst.Length)
                seek(dst,i) = sys.current(e);
            return dst;
        }

        /// <summary>
        /// Writes a source to a target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T deposit<S,T>(in S src, out T dst)
        {
            dst = @as<S,T>(src);
            return ref dst;
        }
    }
}