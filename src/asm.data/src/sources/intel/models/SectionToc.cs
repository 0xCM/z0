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
        [StructLayout(LayoutKind.Sequential, Pack =1)]
        public struct SectionToc
        {
            public SectionNumber Section;

            public TocEntry Toc;

            [MethodImpl(Inline)]
            public SectionToc(in SectionNumber section, in TocEntry toc)
            {
                Section = section;
                Toc = toc;
            }
        }
    }
}