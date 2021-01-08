//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;

    partial struct Buffers
    {
        [MethodImpl(Inline), Op]
        public static ITextBuffer text()
            => new TextBuffer(new StringBuilder());

        [MethodImpl(Inline), Op]
        public static ITextBuffer text(StringBuilder dst)
            => new TextBuffer(dst);
    }
}