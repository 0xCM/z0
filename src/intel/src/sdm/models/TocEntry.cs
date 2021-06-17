//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct IntelSdm
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct TocEntry
        {
            public SectionToc Section;

            public TocTitle Title;

            [MethodImpl(Inline)]
            public TocEntry(in SectionToc section, in TocTitle title)
            {
                Section = section;
                Title = title;
            }
        }

    }
}