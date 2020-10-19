//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    partial class XTend
    {
        [TextUtility]
        public static StringBuilder Build(this string src)
            => new StringBuilder(src);
    }
}