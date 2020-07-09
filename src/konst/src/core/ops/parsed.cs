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

    partial struct core
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

        [MethodImpl(Inline)]
        public static ParseResult<T> parsed<T>(char source, T value)
            => ParseResult<T>.Success(source.ToString(), value);
    }
}