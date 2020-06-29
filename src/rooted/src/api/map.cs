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

    partial class Roots
    {
        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static T[] map<S,T>(IEnumerable<S> src, Func<S,T> f)
            => src.Select(item => f(item)).ToArray();

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
            for(var i= 0; i<count; i++)
                seek(dst,i) = f(skip(src,i));
        }

        /// <summary>
        /// Applies a unary operator to an input sequence and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The operator</param>
        /// <typeparam name="T">The operand type</typeparam>        
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void apply<T>(ReadOnlySpan<T> src, Func<T,T> f, Span<T> dst)
        {
            var count = length(src,dst);
            for(var i= 0; i<count; i++)
                seek(dst,i) = f(skip(src,i));
        }

        /// <summary>
        /// Projects a pair of source spans to target span via a binary operator
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <param name="f">The operator</param>
        /// <typeparam name="T">The operand type</typeparam>        
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void map<T>(ReadOnlySpan<T> x, ReadOnlySpan<T> y, Func<T,T,T> f, Span<T> dst)
        {
            var count = length(x,y);
            for(var i= 0; i<count; i++)
                seek(dst,i) = f(skip(x,i), skip(y,i));
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
            for(var i=0; i<count; i++)            
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
            var dst = alloc<R>(length(x,y));
            map(x,y,f,dst);
            return dst;
        }         
    }
}