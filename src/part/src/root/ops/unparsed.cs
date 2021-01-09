//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct root
    {
        /// <summary>
        /// Defines a parse result that signals failure
        /// </summary>
        /// <param name="source">The input value</param>
        /// <param name="target">The (invalid) target value</param>
        /// <typeparam name="S">The input type</typeparam>
        /// <typeparam name="T">The parse target type</typeparam>
        [MethodImpl(Inline)]
        public static ParseResult<S,T> unparsed<S,T>(S source, T target = default)
            => ParseResult<S,T>.Fail(source);

        /// <summary>
        /// Defines a parse result that signals failure
        /// </summary>
        /// <param name="source">The input value</param>
        /// <param name="target">The (invalid) target value</param>
        /// <param name="reason">The failure reason</param>
        /// <typeparam name="S">The input type</typeparam>
        /// <typeparam name="T">The parse target type</typeparam>
        [MethodImpl(Inline)]
        public static ParseResult<S,T> unparsed<S,T>(S source, T target, string reason)
            => ParseResult<S,T>.Fail(source, reason);

        /// <summary>
        /// Defines a parse result that signals failure
        /// </summary>
        /// <param name="source">The input value</param>
        /// <param name="target">The (invalid) target value</param>
        /// <param name="reason">The failure reason, if available</param>
        /// <typeparam name="S">The input type</typeparam>
        /// <typeparam name="T">The parse target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ParseResult<string,T> unparsed<T>(string source, T target = default)
            => ParseResult<string,T>.Fail(text.empty(source) ? EmptyString : source, text.blank(source) ? $"There was no source text to parse" : EmptyString);

        /// <summary>
        /// Defines a parse result that signals failure
        /// </summary>
        /// <param name="source">The input value</param>
        /// <param name="error">The excaption that occurred</param>
        /// <param name="target">The default (and invalid) target value</param>
        /// <typeparam name="T">The parse target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ParseResult<string,T> unparsed<T>(string source, Exception error, T target = default)
            => ParseResult<string,T>.Fail(text.empty(source) ? EmptyString : source, error?.ToString() ?? EmptyString);

        /// <summary>
        /// Defines a parse result that signals failure
        /// </summary>
        /// <param name="source">The input value</param>
        /// <param name="reason">The failure reason</param>
        /// <typeparam name="T">The parse target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ParseResult<string,T> unparsed<T>(string source, string reason)
            => ParseResult<string,T>.Fail(text.empty(source) ? EmptyString : source, reason);

        /// <summary>
        /// Defines a parse result that signals failure
        /// </summary>
        /// <param name="source">The input value</param>
        /// <param name="reason">The failure reason, if available</param>
        /// <typeparam name="T">The parse target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ParseResult<T> unparsed<T>(char source, object reason = null)
            => ParseResult<T>.Fail(source.ToString(), reason);

    }
}