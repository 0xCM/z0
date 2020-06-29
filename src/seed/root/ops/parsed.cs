//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        /// <summary>
        /// Defines a parse success result
        /// </summary>
        /// <param name="src">The parsed thing</param>
        /// <param name="value">The value that was successfully hydrated from the source/param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ParseResult<T> parsed<T>(object src, T value)
            => ParseResult.Success(src?.ToString() ?? string.Empty, value);
    }

}