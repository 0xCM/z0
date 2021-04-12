//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XTend
    {
        public static ReadOnlySpan<char> ViewChars(this ResDescriptor src)
            => Resources.utf8(src);

        public static string ViewText(this ResDescriptor src)
            => Resources.utf8(src);

        public static ReadOnlySpan<byte> ViewBytes(this ResDescriptor src)
            => Resources.view(src);

    }
}