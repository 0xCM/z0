//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly partial struct TextDocParser
    {
        /// <summary>
        /// Creates a text document parser from a parse function
        /// </summary>
        /// <param name="f">The parse function</param>
        /// <typeparam name="T">The parsed type</typeparam>
        [MethodImpl(Inline)]
        public static TextDocParser<T> create<T>(Func<TextDoc,ParseResult<T>> f)
            => new TextDocParser<T>(f);
    }
}