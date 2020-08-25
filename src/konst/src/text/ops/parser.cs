//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Creates a text document parser from a parse function
        /// </summary>
        /// <param name="f">The parse function</param>
        /// <typeparam name="T">The parsed type</typeparam>
        [MethodImpl(Inline)]
        public static ITextDocParser<T> parser<T>(Func<TextDoc,ParseResult<T>> f)
            => new TextDocParser<T>(f);
    }
}