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
        /// Returns the substring [0,chars-1]
        /// </summary>
        [MethodImpl(Inline), Op]
        public static string left(string src, int chars)
            => blank(src) ? src : src.Substring(0, src.Length < chars ? src.Length : chars);
    }
}