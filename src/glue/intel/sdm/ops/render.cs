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

    using Patterns = IntelSdmPatterns;
    using Markers = IntelSdmMarkers;

    partial struct IntelSdm
    {
        static void render(LineNumber line, ITextBuffer dst)
        {
            dst.AppendFormat(string.Format("{0}:", line));
        }

        public static void render(in SectionNumber sn, in ChapterPage cp, ITextBuffer dst)
        {
            dst.Append("Section ");
            render(sn, dst);
            dst.Append(" Page ");
            render(cp, dst);
        }

        public static void render(LineNumber line, in TocEntry src, ITextBuffer dst)
        {
            render(line, dst);
            dst.Append(src.Title.Content.String);
            dst.Append(" -> ");
            render(src.Section, src.Title.Page, dst);
        }

        public static void render(in SectionPage src, ITextBuffer dst)
        {
            dst.Append(Chars.LBracket);
            render(src.Section, dst);
            dst.Append(Chars.Space);
            render(src.Page, dst);
            dst.Append(Chars.RBracket);
        }

        public static void render(in ChapterPage src, ITextBuffer dst)
        {
            dst.AppendFormat(Patterns.ChapterPage, src.Chapter, src.Page);
        }

        public static void render(LineNumber line, in ChapterNumber src, ITextBuffer dst)
        {
            render(line, dst);
            dst.AppendFormat(Patterns.ChapterNumber, src.Value);
        }

        public static void render(Placeholder src, ITextBuffer dst)
        {
            for(var i=0; i<src.Count; i++)
                dst.AppendFormat("{0}{1}", Placeholder.Space, Placeholder.Dot);
        }

        public static void render(LineNumber line, in SectionNumber src, ITextBuffer dst)
        {
            render(line, dst);
            render(src, dst);
        }

        public static void render(LineNumber line, in TableNumber src, ITextBuffer dst)
        {
            render(line, dst);
            dst.AppendFormat("Table {0}", TextTools.format(src.String));
        }

        public static void render(in SectionNumber src, ITextBuffer dst)
        {
            if(src.IsEmpty)
            {
                dst.Append("0.0.0.0");
                return;
            }

            var count = src.Count;
            if(count >= 1)
                dst.Append(src.A.ToString());
            if(count >= 2)
                dst.Append(string.Format(".{0}",src.B));
            if(count >= 3)
                dst.Append(string.Format(".{0}",src.C));
            if(count >= 4)
                dst.Append(string.Format(".{0}",src.D));
        }
    }
}