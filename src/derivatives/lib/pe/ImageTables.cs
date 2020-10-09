//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly partial struct ImageTables
    {
        public struct ImageContent
        {
            public ImageHeader Header;

            public DirectoryEntry[] Directories;

            public OptionalHeader OptionalHeader;

            public ImageCoreHeader CorHeader;

            public ResourceEntry[] Resources;

            public Image.SectionHeader[] Sections;

            public PdbInfo[] PdbSections;
        }
    }
}