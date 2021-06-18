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

    [ApiHost]
    public readonly partial struct IntelSdm
    {
        [MethodImpl(Inline), Op]
        public static TableNumber table(ReadOnlySpan<char> src)
            => new TableNumber(src);

        [MethodImpl(Inline), Op]
        public static ChapterNumber chapter(byte number)
            => new ChapterNumber(number);

        [MethodImpl(Inline), Op]
        public static VolNumber vol(byte major, char minor)
            => new VolNumber(major, (AsciCode)minor);

        [MethodImpl(Inline), Op]
        public static ChapterPage page(in ChapterNumber chapter, in Page page)
            => new ChapterPage(chapter, page);

        [MethodImpl(Inline), Op]
        public static SectionPage page(in SectionNumber section, in ChapterPage page)
            => new SectionPage(section, page);

        [MethodImpl(Inline), Op]
        public static Location location(in VolPart v, in ChapterNumber c, in Page p)
            => new Location(v, c, p);

        [MethodImpl(Inline), Op]
        public static Placeholder placeholder(char a, char b, byte count)
            => new Placeholder(a,b,count);

        [MethodImpl(Inline), Op]
        public static TocTitle title(in CharBlock128 title, in ChapterPage page)
            => new TocTitle(title, page);

        [MethodImpl(Inline), Op]
        public static TocEntry toc(in SectionNumber sn, in TocTitle title)
            => new TocEntry(sn, title);

        [MethodImpl(Inline), Op]
        public static Toc toc(TocEntry[] src)
            => new Toc(src);
    }
}