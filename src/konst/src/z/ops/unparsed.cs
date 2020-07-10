//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Defines a parse result that signals failure
        /// </summary>
        /// <param name="source">The input vaue</param>
        /// <param name="reason">The failure reason, if available</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ParseResult<S,T> unparsed<S,T>(S source, T target = default)
            => ParseResult<S,T>.Fail(source);

        /// <summary>
        /// Defines a parse result that signals failure
        /// </summary>
        /// <param name="source">The input vaue</param>
        /// <param name="reason">The failure reason, if available</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ParseResult<string,T> unparsed<T>(string source, T target = default)
            => ParseResult<string,T>.Fail(source);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ParseResult<string,T> unparsed<T>(string source, Exception error, T target = default)
            => ParseResult<string,T>.Fail(source, error?.ToString() ?? EmptyString);    

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ParseResult<T> unparsed<T>(char source, object reason = null)
            => ParseResult<T>.Fail(source.ToString(), reason);
    }
}