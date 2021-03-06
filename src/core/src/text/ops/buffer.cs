//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;

    partial struct TextTools
    {
        [Op]
        public static ITextBuffer buffer()
            => new TextBuffer(new StringBuilder());

        [Op]
        public static ITextBuffer buffer(uint capacity)
            => new TextBuffer(capacity);

        [MethodImpl(Inline), Op]
        public static ITextBuffer buffer(StringBuilder dst)
            => new TextBuffer(dst);
    }
}