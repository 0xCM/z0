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

    [ApiHost]
    public readonly struct TextBuffers
    {
        [Op]
        public static ITextBuffer create()
            => new TextBuffer(new StringBuilder());

        [Op]
        public static ITextBuffer create(uint capacity)
            => new TextBuffer(capacity);

        [MethodImpl(Inline), Op]
        public static ITextBuffer create(StringBuilder dst)
            => new TextBuffer(dst);
    }
}