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
        public struct SectionPage
        {
            public SectionNumber Section;

            public ChapterPage Page;

            [MethodImpl(Inline)]
            public SectionPage(in SectionNumber section, in ChapterPage page)
            {
                Section = section;
                Page = page;
            }
        }
    }
}