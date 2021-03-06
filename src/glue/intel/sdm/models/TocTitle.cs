//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct IntelSdm
    {
        public struct TocTitle
        {
            public CharBlock128 Content;

            public ChapterPage Page;

            [MethodImpl(Inline)]
            public TocTitle(in CharBlock128 content, ChapterPage page)
            {
                Content = content;
                Page = page;
            }

            public static TocTitle Empty => default;
        }
    }
}