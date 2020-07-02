//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    partial struct TextDocParser
    {
        /// <summary>
        /// Parses a header row from a line of text
        /// </summary>
        /// <param name="src">The source line</param>
        /// <param name="spec">The text format</param>
        /// <param name="observer">An observer to witness interesting events</param>
        public static Option<TextDocHeader> header(TextDocLine src, in TextDocFormat spec)
            => new TextDocHeader(src.Split(spec).Select(x => x.Trim()).Where(x => x != string.Empty).ToArray());
    }
}