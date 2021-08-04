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
    using static TextTools;
    using static SdmModels;

    using SP = ScalarParser;
    using SQ = SymbolicQuery;

    partial struct SdmParsers
    {
        /// <summary>
        /// Tests whether the specified input sequence is of the form ' .' or '. '
        /// </summary>
        /// <param name="c0">The first character in the placeholder sequence</param>
        /// <param name="c1">The second character in the placeholder sequence</param>
        [MethodImpl(Inline), Op]
        public static bool placeholder(char c0, char c1)
            => (c0 == Placeholder.Space && c1 == Placeholder.Dot) || (c0 == Placeholder.Dot && c1 == Placeholder.Space);

        /// <summary>
        /// Finds the beginning of the toc entry placeholders
        /// </summary>
        /// <param name="src">The data source</param>
        public static int placeholder(string src)
        {
            var i = text.index(src," . . . .");
            var j = text.index(src,". . . . ");
            if(i != NotFound && j != NotFound)
                return min(i,j);
            else
                return NotFound;
        }

        public static int index(ReadOnlySpan<char> src, string marker)
        {
            var index = src.IndexOf(marker);
            if(index > Markers.TableNumber.Length)
                return NotFound;
            else
                return index;
        }

        public static Outcome parse(string src, out TocTitle dst)
        {
            dst = TocTitle.Empty;
            var page = ChapterPage.Empty;
            if(!src.Contains(Markers.TocTitle, NoCase))
                return false;

            var i = placeholder(src);
            var remainder = right(src,i);
            var d = SQ.digitIndex(base10, remainder);
            var input = slice(remainder, d);

            if(parse(input, out page))
            {
                dst = title(left(src,i), page);
                return true;
            }

            return false;
        }

        public static Outcome parse(string src, out ChapterPage dst)
        {
            dst = ChapterPage.Empty;
            var i = text.index(src, Chars.Dash);
            if(i == NotFound)
                return false;

            var a = left(src,i);
            var b = right(src,i);
            if(SP.uint8(base10, a, out var cn) && SP.uint16(base10, b, out var pn))
            {
                dst = page(chapter(cn), pn);
                return true;
            }

            return false;
        }

        [Op]
        public static Outcome parse(string src, out ChapterNumber dst)
        {
            dst = ChapterNumber.Empty;
            var i = text.index(src, Markers.ChapterNumber);
            if(i == NotFound)
                return false;

            var numeric = slice(src, i + Markers.ChapterNumber.Length);
            if(SP.uint8(base10,numeric, out var cn))
            {
                dst = cn;
                return true;
            }

            return false;
        }

        public static Outcome parse(string src, out SectionNumber dst)
        {
            dst = SectionNumber.Empty;
            if(!IsSectionNumber(src))
                return false;

            var digits = text.split(src.ToString(), Chars.Dot);
            var count = digits.Length;
            var result = Outcome.Failure;
            switch(count)
            {
                case 1:
                    if(SP.parse(base10, skip(digits, 0), out dst.A))
                    {
                        dst.Count = 1;
                        result = true;
                    }
                    break;

                case 2:
                        if(
                            SP.parse(base10, skip(digits, 0), out dst.A) &&
                            SP.parse(base10, skip(digits, 1), out dst.B))
                        {
                            dst.Count = 2;
                            result = true;
                        }
                        break;

                case 3: if(
                        SP.parse(base10, skip(digits, 0), out dst.A) &&
                        SP.parse(base10, skip(digits, 1), out dst.B) &&
                        SP.parse(base10, skip(digits, 2), out dst.C))
                        {
                            dst.Count = 3;
                            result = true;
                        }
                        break;

                case 4: if(
                        SP.parse(base10, skip(digits, 0), out dst.A) &&
                        SP.parse(base10, skip(digits, 1), out dst.B) &&
                        SP.parse(base10, skip(digits, 2), out dst.C) &&
                        SP.parse(base10, skip(digits, 3), out dst.D))
                        {
                            dst.Count = 4;
                            result = true;
                        }
                        break;

                default:
                    break;
            }

            return result;
        }

        public static Outcome parse(string src, out TableNumber dst)
        {
            const char DigitSep = Chars.Dash;
            const char NumberEnd = Chars.Dot;
            dst = TableNumber.Empty;

            var i = index(src, Markers.TableNumber);
            if(i != NotFound)
            {
                dst = tablenumber(slice(src, i + Markers.TableNumber.Length));
                return true;
            }
            return false;
        }

        [Op]
        static bool IsSectionNumber(ReadOnlySpan<char> src)
        {
            var count = src.Length;
            if(count == 0)
                return false;

            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                if(SQ.digit(base10,c))
                    continue;

                if(c == Chars.Dot)
                    continue;

                return false;
            }
            return true;
        }
    }
}