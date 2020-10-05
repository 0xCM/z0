//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial class Delegates
    {
        [Free]
        public delegate A Imm8UnaryOp<A>(A a, byte b);

        [Free]
        public delegate A Imm8BinaryOp<A>(A a, A b, byte c);

        [Free]
        public delegate T Projector<T>(in T src);

        /// <summary>
        /// Characterizes a parametric projector
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The operand type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [Free]
        public delegate T Projector<S,T>(in S src);

        /// <summary>
        /// Characterizes a receiver that accepts a stream
        /// </summary>
        /// <typeparam name="T">The stream element type</typeparam>
        [Free]
        public delegate void StreamReceiver<T>(IEnumerable<T> src);

        /// <summary>
        /// Characterizes a receiver that accepts a span
        /// </summary>
        /// <typeparam name="T">The stream element type</typeparam>
        [Free]
        public delegate void SpanReceiver<T>(Span<T> src);

        [Free]
        public delegate bool TernaryPredicate<T>(T a, T b, T c);

        [Free]
        public delegate bool TernaryPredicate<W,T>(T a, T b, T c)
            where W : unmanaged, ITypeWidth;
    }
}