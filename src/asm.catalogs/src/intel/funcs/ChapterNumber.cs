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

    partial class IntelSdmProcessor
    {
        static Outcome parse(ReadOnlySpan<char> src, out ChapterNumber dst)
        {
            if(byte.TryParse(src, out var n))
            {
                dst = n;
                return true;
            }
            else
            {
                dst = ChapterNumber.Empty;
                return false;
            }
        }

        public static void render(LineNumber line, in ChapterNumber src, ITextBuffer dst)
        {
            dst.AppendFormat(string.Format("{0}:", line));
            dst.AppendFormat(Markers.ChapterNumberFormat, src.Value);
        }
    }
}