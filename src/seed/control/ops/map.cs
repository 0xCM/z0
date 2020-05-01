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

    using static Seed;

    partial class Control
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
    }
}