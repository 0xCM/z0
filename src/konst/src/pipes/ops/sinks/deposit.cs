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
        public static void deposit(ReadOnlySpan<string> rows, ISink<string> dst)
        {
            for(var i=0u; i<rows.Length; i++)
            {
                dst.Deposit(skip(rows, i));
                dst.Deposit(Eol);
            }
        }

        [Op]
        public static void deposit(ReadOnlySpan<string> rows, StreamWriter dst)
            => deposit(rows, Sinks.create<string>(dst));

        /// <summary>
        /// Creates a <see cref='Sink{T}'/> from a <see cref='Receiver{T}'/>
        /// </summary>
        /// <param name="dst">The target receiver</param>
        /// <typeparam name="T">The reception type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Sink<T> create<T>(Receiver<T> dst)
            => new Sink<T>(dst);

        /// <summary>
        /// Creates a <see cref='Sink{T}'/> from a <see cref='StreamWriter'/>
        /// </summary>
        /// <param name="dst">The target writer</param>
        /// <typeparam name="T">The reception type</typeparam>
        public static Sink<T> create<T>(StreamWriter dst)
        {
            void Target(in T src) => dst.WriteLine(src);
            return new Sink<T>(Target);
        }

        /// <summary>
        /// Creates a <see cref='Sink{T}'/> from a <see cref='StreamWriter'/>
        /// </summary>
        /// <param name="dst">The target writer</param>
        /// <typeparam name="T">The reception type</typeparam>
        public static Sink<T> create<T>(FileStream dst)
        {
            void Target(in T src)
                => FS.write(src?.ToString() ?? EmptyString, dst);

            return new Sink<T>(Target);
        }


       [MethodImpl(Inline)]
       public static void deposit<S,T>(in S src, in ValuePipe<S,T> dst)
            where S : struct
            where T : struct
                => dst.Buffer.Add(src);

        [MethodImpl(Inline), Closures(Closure)]
        public static void deposit<T>(in T src, in ValuePipe<T> dst)
            where T : struct
                => dst.Buffer.Add(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void deposit<T>(in T src, in Pipe<T> dst)
            => dst.Buffer.Add(src);

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
        /// Writes a source to a target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T deposit<S,T>(in S src, out T dst)
        {
            dst = z.@as<S,T>(src);
            return ref dst;
        }

        /// <summary>
        /// Fills a caller-supplied span with data produced by a T-enumerable
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> deposit<T>(IEnumerable<T> src, Span<T> dst)
        {
            var i = 0u;
            var e = sys.enumerator(src);
            while(sys.next(e) && i < dst.Length)
                z.seek(dst,i) = sys.current(e);
            return dst;
        }
    }
}