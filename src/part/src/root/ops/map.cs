//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    partial struct root
    {
        /// <summary>
        /// Projects a sequence of <typeparamref name='S'/> cells into a <typeparamref name='T'/> cell receiver
        /// </summary>
        /// <param name="src">The source cells</param>
        /// <param name="f">The projector</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> map<S,T>(ReadOnlySpan<S> src, Func<S,T> f, Span<T> dst)
        {
            var count = min(src.Length, dst.Length);
            ref readonly var input = ref first(src);
            ref var target = ref first(dst);
            for(var i=0u; i<count; i++)
                seek(target,i) = f(skip(input,i));
            return dst;
        }

        /// <summary>
        /// Projects a sequence of <typeparamref name='S'/> cells into a <typeparamref name='T'/> cell receiver
        /// </summary>
        /// <param name="src">The source cells</param>
        /// <param name="f">The projector</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        public static Span<T> map<S,T>(ReadOnlySpan<S> src, Func<S,T> f)
        {
            var dst = sys.alloc<T>(src.Length);
            map(src, f, dst);
            return dst;
        }

        /// <summary>
        /// Projects a sequence of <typeparamref name='S'/> cells into an allocated <typeparamref name='T'/> cell receiver
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
            var buffer = sys.alloc<T>(count);
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
        /// Iterates a pair of readonly spans in tandem, invoking a binary projector for each cell pair and deposits the result in a caller-supplied target
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The cell type of the first operand</typeparam>
        /// <typeparam name="T">The cell type of the second operand</typeparam>
        [MethodImpl(Inline)]
        public static Span<R> map<S,T,R>(ReadOnlySpan<S> a, ReadOnlySpan<T> b, Func<S,T,R> f, Span<R> dst)
        {
            var count = Math.Min(a.Length, b.Length);
            for(var i=0u; i<count; i++)
                seek(dst,i) = f(skip(a,i), skip(b,i));
            return dst;
        }

        /// <summary>
        /// Iterates a pair of readonly spans in tandem, invoking a function for each cell pair and deposits the result to an allocated target
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="f">The action to invoke</param>
        /// <typeparam name="S">The cell type of the first operand</typeparam>
        /// <typeparam name="T">The cell type of the second operand</typeparam>
        public static Span<R> map<S,T,R>(ReadOnlySpan<S> a, ReadOnlySpan<T> b, Func<S,T,R> f)
        {
            var count = Math.Min(a.Length, b.Length);
            var dst = sys.alloc<R>(count);
            map(a,b,f,dst);
            return dst;
        }
    }
}