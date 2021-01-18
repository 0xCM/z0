//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static TextRules;

    partial class XText
    {
        [TextUtility]
        public static string Between(this string src, char left, char right)
            => Parse.between(src,left,right);
    }
}