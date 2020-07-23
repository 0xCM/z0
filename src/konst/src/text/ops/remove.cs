//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Removes an identified substring wherever it occurs in the source
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="match">The string to remove</param>
        [MethodImpl(Inline), Op]
        public static string remove(string src, string match)
            => src.Replace(match, EmptyString);
    }
}