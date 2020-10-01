//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Applies the supplied function to each element in the input sequence to produce a list
        /// </summary>
        /// <typeparam name="X">The input sequence item type</typeparam>
        /// <typeparam name="S">The output sequence item type</typeparam>
        /// <param name="seq">The sequence to transform</param>
        /// <param name="f">The transformation function</param>
        public static Y[] mapi<X,Y>(IEnumerable<X> seq, Func<int,X,Y> f)
        {
            var src = seq.ToArray();
            var dst = new Y[src.Length];
            for (var i = 0; i < src.Length; i++)
                dst[i] = f(i, src[i]);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void map<T>(ReadOnlySpan<T> src, Func<T,T> f, Span<T> dst)
        {
            var count = min(src.Length, dst.Length);
            ref readonly var s = ref first(src);
            ref var t = ref first(dst);
            for(var i=0u; i<count; i++)
                seek(t,i) = f(skip(s,i));
        }

        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T[] map<S,T>(IEnumerable<S> src, Func<S,T> f)
        {
            var source = sys.span(src);
            var count = source.Length;
            var buffer = alloc<T>(count);
            var target = span(buffer);
            for(var i=0u; i<count; i++)
                seek(target,i) = f(skip(source,i));
            return buffer;
        }

        /// <summary>
        /// Projects a source value, if non-null, onto a target value; otherwise, returns value raised by a caller-supplied emitter
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="some">The projector</param>
        /// <param name="none">The alternative emitter</param>
        /// <typeparam name="S">The source value type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T map<S,T>(S? src, Func<S,T> some, Func<T> none)
            where S : struct
                => src != null ? some(src.Value) : none();

        /// <summary>
        /// Projects a source value, if non-null, onto a target value; otherwise, returns the target's default value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source value type</typeparam>
        /// <typeparam name="T">The target value type</typeparam>
        [MethodImpl(Inline)]
        public static T map<S,T>(S? src, Func<S,T> f)
            where S : struct
            where T : struct
                => src.HasValue ? f(src.Value) : default(T);

        /// <summary>
        /// Projects a source span to target span via a supplied transformation
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The transformation</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static void map<S,T>(ReadOnlySpan<S> src, Func<S,T> f, Span<T> dst)
        {
            var count = length(src,dst);
            for(var i=0u; i<count; i++)
                seek(dst,i) = f(skip(src,i));
        }

        /// <summary>
        /// Iterates a pair of readonly spans in tandem, invoking a function for each cell pair
        /// and deposits the result in a caller-supplied target
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="f">The action to invoke</param>
        /// <typeparam name="S">The cell type of the first operand</typeparam>
        /// <typeparam name="T">The cell type of the second operand</typeparam>
        [MethodImpl(Inline)]
        public static void map<S,T,R>(ReadOnlySpan<S> x, ReadOnlySpan<T> y, Func<S,T,R> f, Span<R> dst)
        {
            var count = length(x,y);
            for(var i=0u; i<count; i++)
                seek(dst,i) = f(skip(x,i),skip(y,i));
        }

        /// <summary>
        /// Iterates a pair of readonly spans in tandem, invoking a function for each cell pair,
        /// and deposits the result to an allocated target that is returned
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="f">The action to invoke</param>
        /// <typeparam name="S">The cell type of the first operand</typeparam>
        /// <typeparam name="T">The cell type of the second operand</typeparam>
        [MethodImpl(Inline)]
        public static Span<R> map<S,T,R>(ReadOnlySpan<S> x, ReadOnlySpan<T> y, Func<S,T,R> f)
        {
            var dst = sys.alloc<R>(length(x,y));
            map(x,y,f,dst);
            return dst;
        }
    }
}