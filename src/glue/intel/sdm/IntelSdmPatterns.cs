//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Markers = IntelSdmMarkers;

    public readonly struct IntelSdmPatterns
    {
        public const string ChapterNumber = Markers.ChapterNumber + "{0}";

        public const string TableNumber = Markers.TableNumber + "{0}";

        public const string ChapterPage = "{0}-{1}";
    }
}