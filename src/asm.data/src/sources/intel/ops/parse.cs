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

    using TN = IntelSdm.TableNumber;

    partial struct IntelSdm
    {
       /// <summary>
        /// Parses content of the form 'Table {major}-{minor}
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        public static Outcome parse(string src, out TableNumber dst)
        {
            dst = TableNumber.Empty;
            var i = src.IndexOf(TN.Marker);
            if(i == NotFound)
                return (false, string.Format("Marker '{0}' not found", TN.Marker));
            var number = text.slice(src,i + TN.MarkerLength);
            i = number.IndexOf(TN.Sep);
            if(i == NotFound)
                return (false, string.Format("Separator '{0}' not found", TN.Sep));
            var major = number.LeftOfIndex(i);
            if(major.Length!=1)
                return (false, string.Format("Expected a single character but found '{0}'", major));
            var minor = number.RightOfIndex(i);
            var outcome = DataParser.parse(minor, out ushort _minor);
            if(outcome.Fail)
                return outcome;

            dst = new TableNumber(major[0], _minor);
            return true;
        }

        public static Outcome parse(string src, out ChapterPage dst)
        {
            var outcome = Outcome.Success;
            dst = ChapterPage.Empty;
            var i = text.index(src,Chars.Dash);
            if(i == NotFound)
            {
                outcome = (false, string.Format("Chapater/Page separator '{0}' not found", Chars.Dash));
                return outcome;
            }
            var left = src.LeftOfIndex(i);
            outcome += DataParser.parse(left, out dst.Chapter);
            var right = src.RightOfIndex(i);
            outcome += DataParser.parse(left, out dst.Page);
            return outcome;
        }

    }
}