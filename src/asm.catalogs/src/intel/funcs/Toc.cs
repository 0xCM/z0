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
    using static IntelSdm;

    using Markers = IntelSdmMarkers;

    partial class IntelSdmProcessor
    {
        [MethodImpl(Inline), Op]
        public static bool IsTocEntry(ReadOnlySpan<char> src)
            => src.Contains(Markers.TocTitle, NoCase);

        public static Outcome parse(ReadOnlySpan<char> src, out TocEntry dst)
        {
            const string Match = " .";
            var page = ChapterPage.Empty;

            if(!IsTocEntry(src))
            {
                dst = TocEntry.Empty;
                return false;
            }

            var i = placeholder(src);
            var title = text.left(src,i);
            var remainder = text.right(src,i);
            var d = IndexOfFirstDigit(remainder);
            var input = slice(remainder,d);

            parse2(input, out page);

            dst = toc(title, page);
            return true;
        }

        public static void render(LineNumber line, in TocEntry src, ITextBuffer dst)
        {
            dst.AppendFormat(string.Format("{0}:", line));
            dst.Append(src.Content.Format());
            dst.Append(" -> Page ");
            render(src.Page, dst);
        }

        public static int IndexOfFirstDigit(ReadOnlySpan<char> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                if(SymbolicQuery.digit(base10, skip(src, i)))
                    return i;
            return NotFound;
        }
    }
}