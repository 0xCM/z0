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
        public static SectionNumber section(ushort a)
            => new SectionNumber(a);

        [MethodImpl(Inline), Op]
        public static SectionNumber section(ushort a, ushort b)
            => new SectionNumber(a, b);

        [MethodImpl(Inline), Op]
        public static SectionNumber section(ushort a, ushort b, ushort c)
            => new SectionNumber(a, b, c);

        [MethodImpl(Inline), Op]
        public static SectionNumber section(ushort a, ushort b, ushort c, ushort d)
            => new SectionNumber(a, b, c, d);

        [MethodImpl(Inline), Op]
        public static Page page(ushort number)
            => new Page(number);

        [MethodImpl(Inline), Op]
        public static ChapterPage page(in ChapterNumber chapter, in Page page)
            => new ChapterPage(chapter, page);

        [MethodImpl(Inline), Op]
        public static SectionPage page(in SectionNumber section, in ChapterPage page)
            => new SectionPage(section, page);

        [MethodImpl(Inline), Op]
        public static Location location(in VolumePart v, in ChapterNumber c, in Page p)
            => new Location(v, c, p);

        [MethodImpl(Inline), Op]
        public static Placeholder placeholder(byte count)
            => new Placeholder(count);

        [MethodImpl(Inline), Op]
        public static TocEntry toc(in CharBlock128 title, in ChapterPage page)
            => new TocEntry(title, page);

        [MethodImpl(Inline), Op]
        public static SectionToc toc(in SectionNumber section, in CharBlock128 title, in ChapterPage page)
            => new SectionToc(section, toc(title, page));
    }
}