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

    using static Seed;
    
    partial class XTend
    {
        /// <summary>
        /// Sequenteially condenses a sequence of arrays into a single array
        /// </summary>
        /// <param name="src">The many</param>
        /// <typeparam name="T">The array element type</typeparam>
        public static T[] Join<T>(this T[][] src)
            => System.Linq.Enumerable.SelectMany(src,x => x).ToArray();

        public static T[] Join<S,T>(this S[][] src, Func<S,T> f)
            => src.Join().Select(f);

        public static T[] SelectMany<S,T>(this S[][] src, Func<S,T> f)
            => src.Join().Select(f);

        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The mapping function</param>
        public static T[] Map<S,T>(this IEnumerable<S> src, Func<S,T> f)
            => Control.map(src,f);

        /// <summary>
        /// Projects a source value, if non-null, onto a target value; otherwise, returns the target's default value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source value type</typeparam>
        /// <typeparam name="T">The target value type</typeparam>
        [MethodImpl(Inline)]
        public static T Map<S,T>(this S? src, Func<S,T> f)
            where S : struct
            where T : struct
                => Control.map(src,f);

        /// <summary>
        /// Projects a source value, if non-null, onto a target value; otherwise, returns value raised by a caller-supplied emitter
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="some">The projector</param>
        /// <param name="none">The alternative emitter</param>
        /// <typeparam name="S">The source value type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Map<S,T>(this S? src, Func<S,T> some, Func<T> none)
            where S : struct
                => Control.map(src,some,none);

        [MethodImpl(Inline)]
        public static S MapValueOrDefault<T,S>(this T? x, Func<T,S> f, S @default = default(S))
            where T : struct
                => x != null ? f(x.Value) : @default;

        [MethodImpl(Inline)]
        public static S MapValueOrElse<T,S>(this T? x, Func<T,S> f, Func<S> @else)
            where T : struct
                => x != null ? f(x.Value) : @else();
    }
}