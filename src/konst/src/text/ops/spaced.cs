//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Formats the content with a space on either side
        /// </summary>
        /// <param name="content">The source content</param>
        [MethodImpl(Inline)]
        public static string spaced(object content)
            => $" {content} ";

        [MethodImpl(Inline)]
        public static string spaced(char c)
            => concat(Space, c, Space);

        /// <summary>
        /// Separates each item with a space
        /// </summary>
        public static string spaced(IEnumerable<object> items)
            => string.Join(Chars.Space, items);
    }
}