//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Memories
    {
        /// <summary>
        /// Defines a parse failure result
        /// </summary>
        /// <param name="src">The unparseable thing</param>
        /// <param name="reason">The reason the parser failed, if know, or if laziness doesn't prevent reason specification</param>
        /// <typeparam name="T">The target type that could not be hydrated </typeparam>
        [MethodImpl(Inline)]
        public static ParseResult<T> unparsed<T>(object src, string reason = null)
            => ParseResult.Fail<T>(src?.ToString() ?? string.Empty, reason);
    }
}