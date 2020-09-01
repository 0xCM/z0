//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Linq.Expressions;
    using System.Linq;
    using System.Reflection.Emit;
    using System.Reflection.Metadata.Ecma335;
    using System.Reflection.Metadata;
    //using System.Reflection.PortableExecutable;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System;

    using Pe = System.Reflection.PortableExecutable;
    using Ecma = System.Reflection.Metadata.Ecma335;
    using Lx = System.Linq.Expressions;
    using Emit = System.Reflection.Emit;

    using static Konst;

    public readonly partial struct ImageTables
    {
        [Table]
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