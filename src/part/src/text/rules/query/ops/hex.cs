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
        /// Determines whether a <see cref='char'/> is within the range [a..f] or the range [A..F]
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit hex(char src)
            => lowerhex(src) || upperhex(src);
    }
}
