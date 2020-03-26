//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Components;

    partial class XText
    {
        /// <summary>
        /// Removes whitespace characters from a string
        /// </summary>
        /// <param name="src">The source string</param>
        public static string RemoveBlanks(this string src)
            => src.RemoveAny(core.seq(AsciSym.Space, AsciEscape.LineFeed, AsciEscape.NewLine, AsciEscape.Tab));
    }
}