//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    public struct PeImage    
    {
        public PeImageHeader Header;

        public ImageOptionalHeader OptionalHeader;

        public CorHeader CorHeader;

        public ResourceEntry Resources;

        public SectionHeader[] Sections;

        public PdbInfo[] PdbSections;

        public IMAGE_DATA_DIRECTORY[] Directories;
    }
}