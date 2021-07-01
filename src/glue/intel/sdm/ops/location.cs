//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {
        [MethodImpl(Inline), Op]
        public static DocLocation location(in VolPart v, in ChapterNumber c, in Page p)
            => new DocLocation(v, c, p);
    }
}