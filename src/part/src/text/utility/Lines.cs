//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XText
    {
        [TextUtility]
        public static Index<TextLine> Lines(this string src, bool keepblank = false)
            => text.lines(src, keepblank);
    }
}