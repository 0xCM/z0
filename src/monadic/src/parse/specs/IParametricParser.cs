//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a non-parametric text parser that defines a parametric parse function
    /// </summary>
    public interface IParametricParser
    {
        /// <summary>
        /// Attemps to parse the source text as a parametrically-identified target type
        /// </summary>
        /// <param name="text">The source text</param>
        /// <typeparam name="T">The target type</typeparam>
        ParseResult<T> Parse<T>(string text);

        /// <summary>
        /// Returns a successfully parsed value, if possible; otherwise returns a caller-supplied default value
        /// </summary>
        /// <param name="src">The text to parse</param>
        /// <param name="@default">The value returned if the parse function fails</param>
        /// <typeparam name="T">The target type</typeparam>
        T Parse<T>(string src, T @default)
            => Parse<T>(src).ValueOrDefault(@default);
    }

    /// <summary>
    /// Characterizes a source-parametric parser that defines a parametric parse function
    /// </summary>
    public interface IParametricParser<S>
    {
        /// <summary>
        /// Attemps to parse the source as a parametrically-identified target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        ParseResult<S,T> Parse<T>(S src);

        /// <summary>
        /// Returns a successfully parsed value, if possible; otherwise returns a caller-supplied default value
        /// </summary>
        /// <param name="src">The value to parse</param>
        /// <param name="@default">The value returned if the parse function fails</param>
        /// <typeparam name="T">The target type</typeparam>
        T Parse<T>(S src, T @default)
            => Parse<T>(src).ValueOrDefault(@default);

    }
}