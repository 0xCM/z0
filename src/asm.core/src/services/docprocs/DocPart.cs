//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [SymbolSource("Clasifies document parts")]
    public enum DocPart : byte
    {
        None = 0,

        [Symbol("Index", "Designates a document index")]
        Index = 1,

        [Symbol("TOC", "Designates a document TOC")]
        TOC = 2,

        [Symbol("Vol", "Designates a document volume")]
        Vol,

        [Symbol("Vol", "Designates a document chaptre")]
        Chapter,

        [Symbol("Vol", "Designates a chapter part")]
        Section,

        [Symbol("Table", "Designates a docment table")]
        Table,

        [Symbol("Table", "Designates a docment figure")]
        Figure,

        [Symbol("TocEntry", "Designates an entry in a TOC")]
        TocEntry,

        [Symbol("TocEntry", "Designates an entry in an index")]
        IndexEntry,
    }
}