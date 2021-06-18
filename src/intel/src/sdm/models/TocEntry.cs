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
        public struct TocEntry
        {
            public SectionNumber Section;

            public TocTitle Title;

            [MethodImpl(Inline)]
            public TocEntry(in SectionNumber section, in TocTitle toc)
            {
                Section = section;
                Title = toc;
            }

            public static TocEntry Empty => default;
        }
    }
}