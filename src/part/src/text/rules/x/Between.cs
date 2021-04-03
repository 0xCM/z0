//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    partial class XText
    {
        [TextUtility]
        public static string Between(this string src, char left, char right)
            => text.between(src, left, right);
    }
}