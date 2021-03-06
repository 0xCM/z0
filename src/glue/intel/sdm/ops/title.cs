//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct IntelSdm
    {
        [MethodImpl(Inline), Op]
        public static TocTitle title(in CharBlock128 title, in ChapterPage page)
            => new TocTitle(title, page);
    }
}