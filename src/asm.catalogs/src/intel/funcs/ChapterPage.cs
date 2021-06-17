//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static Root;
    using static IntelSdm;

    using Markers = IntelSdmMarkers;
    using Patterns = IntelSdmPatterns;

    partial class IntelSdmProcessor
    {
        // public static Outcome parse(ReadOnlySpan<char> src, out ChapterPage dst)
        // {
        //     dst = ChapterPage.Empty;
        //     var i = text.index(src, Chars.Dash);
        //     if(i == NotFound)
        //         return false;

        //     if(parse(text.left(src,i), out ChapterNumber chapter) && parse(text.right(src,i), out Page page))
        //     {
        //         dst = new ChapterPage(chapter, page);
        //         return true;
        //     }

        //     return false;
        // }

        public static Outcome parse(ReadOnlySpan<char> src, out ChapterPage dst)
        {
            dst = ChapterPage.Empty;
            var i = text.index(src, Chars.Dash);
            var left = text.left(src,i);
            var right = text.right(src,i);
            parse(left, out ChapterNumber chapter);
            parse(right, out Page page);
            dst = new ChapterPage(chapter, page);
            return true;
        }

        public static void render(in ChapterPage src, ITextBuffer dst)
        {
            dst.AppendFormat(Patterns.ChapterPage, src.Chapter, src.Page);
        }
    }
}