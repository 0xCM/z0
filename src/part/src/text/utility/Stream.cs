//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using static Part;

    partial class XText
    {
        [TextUtility]
        public static MemoryStream Stream(this string src, Encoding encoding = null)
            => text.stream(src, encoding);
    }
}