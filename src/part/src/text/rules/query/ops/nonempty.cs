//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct TextQuery
    {
        /// <summary>
        /// Tests whether a specified <see cref='string'/> is nonempty
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static bool nonempty(string src)
            => !string.IsNullOrEmpty(src);
    }
}