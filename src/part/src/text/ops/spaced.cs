//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class text
    {
        /// <summary>
        /// Formats the content with a space on either side
        /// </summary>
        /// <param name="content">The source content</param>
        [MethodImpl(Inline), Op]
        public static string spaced(object content)
            => $" {content} ";

        [Op]
        public static string spaced(char c)
            => concat(Space, c, Space);

        /// <summary>
        /// Separates each item with a space
        /// </summary>
        [MethodImpl(Inline), Op]
        public static string spaced(IEnumerable<object> items)
            => string.Join(Chars.Space, items);
    }
}