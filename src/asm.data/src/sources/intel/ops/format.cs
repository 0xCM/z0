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
        public static string format(ChapterPage src)
            => string.Format(ChapterPage.RenderPattern, src.Chapter, src.Page);

        public static string format(VolumePage src)
            => string.Format("Vol. {0} {1}", src.VolName, format(src.Page));
    }
}