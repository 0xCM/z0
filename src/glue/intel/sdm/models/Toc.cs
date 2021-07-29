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
    using static SdmModels;

    partial struct IntelSdm
    {
        [MethodImpl(Inline), Op]
        public static TocEntry toc(in SectionNumber sn, in TocTitle title)
            => new TocEntry(sn, title);

        public readonly struct Toc
        {
            readonly Index<TocEntry> Data;

            [MethodImpl(Inline)]
            public Toc(TocEntry[] sections)
            {
                Data = sections;
            }

            public Span<TocEntry> Entries
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
            }

            public uint EntryCount
            {
                [MethodImpl(Inline)]
                get => Data.Count;
            }
        }
    }
}