//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    partial struct Buffers
    {
        [MethodImpl(Inline), Op]
        public static DynamicTextBuffer text()
            => new DynamicTextBuffer(new StringBuilder());

        [MethodImpl(Inline), Op]
        public static DynamicTextBuffer text(StringBuilder dst)
            => new DynamicTextBuffer(dst);
    }
}