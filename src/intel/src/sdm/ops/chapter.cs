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

    using Markers = IntelSdmMarkers;
    using Patterns = IntelSdmPatterns;

    partial struct IntelSdm
    {
        [MethodImpl(Inline), Op]
        public static bool IsTocEntry(ReadOnlySpan<char> src)
            => src.Contains(Markers.TocTitle, NoCase);

        public static Outcome parse(ReadOnlySpan<char> src, out TocTitle dst)
        {
            var page = ChapterPage.Empty;
            if(!IsTocEntry(src))
            {
                dst = TocTitle.Empty;
                return false;
            }

            var i = placeholder(src);
            var title = TextTools.left(src,i);
            var remainder = TextTools.right(src,i);
            var d = IndexOfFirstDigit(remainder);
            var input = slice(remainder,d);

            if(IntelSdm.parse(input, out page))
            {
                dst = IntelSdm.title(title, page);
                return true;
            }
            else
            {
                dst = TocTitle.Empty;
                return false;
            }
        }

        static void render(LineNumber line, ITextBuffer dst)
        {
            dst.AppendFormat(string.Format("{0}:", line));
        }

        public static void render(in SectionNumber sn, in ChapterPage cp, ITextBuffer dst)
        {
            dst.Append("Section ");
            IntelSdm.render(sn, dst);
            dst.Append(" Page ");
            IntelSdm.render(cp, dst);
        }

        public static void render(LineNumber line, in TocEntry src, ITextBuffer dst)
        {
            render(line, dst);
            dst.Append(src.Title.Content.String);
            dst.Append(" -> ");
            render(src.Section, src.Title.Page, dst);
        }

        public static int IndexOfFirstDigit(ReadOnlySpan<char> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                if(SymbolicQuery.digit(base10, skip(src, i)))
                    return i;
            return NotFound;
        }

        public static void render(in SectionPage src, ITextBuffer dst)
        {
            dst.Append(Chars.LBracket);
            render(src.Section, dst);
            dst.Append(Chars.Space);
            render(src.Page, dst);
            dst.Append(Chars.RBracket);
        }

        public static Outcome parse(ReadOnlySpan<char> src, out ChapterPage dst)
        {
            dst = ChapterPage.Empty;
            var i = TextTools.index(src, Chars.Dash);
            if(i != NotFound)
            {
                var left = TextTools.left(src,i);
                var right = TextTools.right(src,i);
                if(byte.TryParse(left, out var cn) && ushort.TryParse(right, out var pn))
                {
                    dst = new ChapterPage(new ChapterNumber(cn), new Page(pn));
                    return true;

                }
            }
            return false;
        }

        public static void render(in ChapterPage src, ITextBuffer dst)
        {
            dst.AppendFormat(Patterns.ChapterPage, src.Chapter, src.Page);
        }

        [Op]
        public static Outcome parse(ReadOnlySpan<char> src, out ChapterNumber dst)
        {
            var i = TextTools.index(src, Markers.ChapterNumber);
            if(i != NotFound)
            {
                var numeric = slice(src, i + Markers.ChapterNumber.Length);
                if(byte.TryParse(numeric, out var cn))
                {
                    dst = cn;
                    return true;
                }
            }

            dst = ChapterNumber.Empty;
            return false;
        }

        public static void render(LineNumber line, in ChapterNumber src, ITextBuffer dst)
        {
            render(line, dst);
            dst.AppendFormat(Patterns.ChapterNumber, src.Value);
        }
    }
}