//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct IntelSdm
    {
        [SymbolSource("Clasifies document parts")]
        public enum DocPartKind : byte
        {
            None = 0,

            VolNumber,

            ChapterNumber,

            TableNumber,

            SectionNumber,

            FigureNumber,

            TocEntry,

            IndexEntry,
        }
    }
}