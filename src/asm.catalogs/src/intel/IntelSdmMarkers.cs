//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    using System;

    using static Root;

    using Markers = IntelSdmMarkers;

    readonly struct IntelSdmMarkers
    {
        public const string ChapterNumber = "Chapter ";

        public const string ChapterNumberFormat = ChapterNumber + "{0}";

        public const string TableNumber = "Table ";

        public const string TableNumberFormat = TableNumber + "{0}";

        public const string TocTitle = " . . . . . . . . . .";

        public const string ChapterPageRenderPattern = "{0}-{1}";

        public static int index(ReadOnlySpan<char> src, string marker)
        {
            var index = src.IndexOf(marker);
            if(index > Markers.TableNumber.Length)
                return NotFound;
            else
                return index;
        }
    }
}