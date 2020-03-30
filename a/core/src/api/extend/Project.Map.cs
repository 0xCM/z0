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

    using static Components;

    partial class XTend
    {
        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The mapping function</param>
        public static T[] Map<S, T>(this IEnumerable<S> src, Func<S, T> f)
            => src.Select(item => f(item)).ToArray();

        [MethodImpl(Inline)]
        public static Y Map<X,Y>(this X? x, Func<X,Y> f)
            where X : struct
            where Y : struct
                => x.HasValue ? f(x.Value) : default(Y);

        [MethodImpl(Inline)]
        public static S Map<T, S>(this T? x, Func<T, S> ifSome, Func<S> ifNone)
            where T : struct
                    => x != null ? ifSome(x.Value) : ifNone();

        [MethodImpl(Inline)]
        public static S MapValueOrDefault<T, S>(this T? x, Func<T, S> f, S @default = default(S))
            where T : struct
                => x != null ? f(x.Value) : @default;

        [MethodImpl(Inline)]
        public static S MapValueOrElse<T, S>(this T? x, Func<T, S> f, Func<S> @else)
            where T : struct
                => x != null ? f(x.Value) : @else();
    }
}