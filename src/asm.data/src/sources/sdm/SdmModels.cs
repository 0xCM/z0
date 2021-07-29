//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct SdmModels
    {
        [MethodImpl(Inline), Op]
        public static ChapterNumber chapter(byte number)
            => new ChapterNumber(number);

        [MethodImpl(Inline), Op]
        public static TableNumber tablenumber(ReadOnlySpan<char> src)
            => new TableNumber(src);

        [MethodImpl(Inline), Op]
        public static TocTitle title(in CharBlock128 title, in ChapterPage page)
            => new TocTitle(title, page);

        [MethodImpl(Inline), Op]
        public static ModeSupport support(Mode64Support m64, Mode32Support m32)
            =>new ModeSupport(m64,m32);

        [MethodImpl(Inline), Op]
        public static DocLocation location(in VolPart v, in ChapterNumber c, in Page p)
            => new DocLocation(v, c, p);

        [MethodImpl(Inline), Op]
        public static ChapterPage page(in ChapterNumber chapter, in Page page)
            => new ChapterPage(chapter, page);

        [MethodImpl(Inline), Op]
        public static ChapterPage page(in ChapterNumber chapter, ushort page)
            => new ChapterPage(chapter, page);

        [MethodImpl(Inline), Op]
        public static SectionPage page(in SectionNumber section, in ChapterPage page)
            => new SectionPage(section, page);

        [MethodImpl(Inline), Op]
        public static PageFooter footer(string l0, string l1, string r0, string r1)
            => new PageFooter(l0,l1,r0,r1);

        [MethodImpl(Inline), Op]
        public static VolPartNumber volpart(byte major, char minor)
            => new VolPartNumber(major, (AsciCode)minor);
    }
}