// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct root
    {
        /// <summary>
        /// Defines a successful parse result
        /// </summary>
        /// <param name="source">The input vaue</param>
        /// <param name="value">The parsed value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ParseResult<S,T> parsed<S,T>(S source, T value)
            => ParseResult<S,T>.Success(source, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ParseResult<T> parsed<T>(char source, T value)
            => ParseResult<T>.Success(source.ToString(), value);

        /// <summary>
        /// Defines a parse success result
        /// </summary>
        /// <param name="src">The parsed thing</param>
        /// <param name="value">The value that was successfully hydrated from the source/param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ParseResult<T> parsed<T>(object src, T value)
            => ParseResult.win(src?.ToString() ?? EmptyString, value);
    }
}